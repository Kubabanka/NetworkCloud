using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TSST.Configuration;
using TSST.Messages;

namespace TSST.Cloud
{
    public class Cloud
    {
        private const char _empty = '\0';
        private const char _inputType = 'I';
        private const char _outputType = 'O';

        private event EventHandler<RequestEventArgs> requestReceived;
        public event EventHandler<LinkUsageEventArgs> LinkUsed;

        private List<LinkConfig> linkList;

        private Dictionary<string, TcpClient> clientDictionary;

        private static readonly object syncRoot = new object();

        public Cloud()
        {
            requestReceived += Cloud_requestReceived;
        }

        public void Initialize(string path, int port)
        {
            linkList = LinkConfig.GetConfiguration(path);
            if (linkList == null)
                throw new NullReferenceException(nameof(linkList));
            var r = new RegisterMessage();
            var server = new TcpListener(IPAddress.Any, port);
            clientDictionary = new Dictionary<string, TcpClient>();
            server.Start();
            while (true)
            {
                var client = server.AcceptTcpClient();
                var clientThread = new Thread(new ParameterizedThreadStart(HandleClientRequest));
                clientThread.Start(client);
            }
        }

        private void Cloud_requestReceived(object sender, RequestEventArgs e)
        {
            string id = e.Id;
            string data = e.Data;
            bool succeeded = false;
            string receiverId=string.Empty;
            try
            {
                var link = linkList
                    .Where(y => id == string.Format("O#{0}:{1}", y.SourceID, y.SourcePort))
                    .FirstOrDefault();
                if (link != null)
                {
                    receiverId = string.Format("I#{0}:{1}", link.DestinationID, link.DestinationPort);
                    var receiverClient = GetFromDictionary(receiverId);
                    if (receiverClient != null && receiverId.Length > 3)
                    {
                        var writer = new BinaryWriter(receiverClient.GetStream());
                        writer.Write(data);
                        succeeded = true;
                    }
                }
            }
            catch { }
            if (!string.IsNullOrEmpty(receiverId))
            {
                var eventHandler = LinkUsed;
                if (eventHandler != null)
                    eventHandler(this, new LinkUsageEventArgs(id, receiverId, succeeded));
            }
        }

        private void HandleClientRequest(object obj)
        {
            var client = (TcpClient)obj;
            var clientStream = client.GetStream();
            string id = string.Empty;
            char portType = _empty;
            var reader = new BinaryReader(clientStream);
            try
            {
                string input = reader.ReadString();
                var registerMessage = (RegisterMessage)MessagesSerializer.Deserialize(input, typeof(RegisterMessage));
                id = registerMessage.Id;
                portType = id.First();
                if(portType == _inputType)
                    AddOrUpdateDictionary(id, client);
                while (true)
                {
                    var request = reader.ReadString();
                    if (requestReceived != null)
                        requestReceived(this, new RequestEventArgs(id, request));
                }
            }
            catch { }
            if (portType == _inputType)
                RemoveFromDictionary(id);
        }

        private void AddOrUpdateDictionary(string id, TcpClient client)
        {
            lock (syncRoot)
            {
                if (clientDictionary.ContainsKey(id))
                {
                    clientDictionary[id] = client;
                }
                else
                {
                    clientDictionary.Add(id, client);
                }
            }
        }

        private void RemoveFromDictionary(string id)
        {
            lock (syncRoot)
            {
                if (clientDictionary.ContainsKey(id))
                    clientDictionary.Remove(id);
            }
        }

        private TcpClient GetFromDictionary(string id)
        {
            lock (syncRoot)
            {
                if (clientDictionary.ContainsKey(id))
                    return clientDictionary[id];
            }
            return null;
        }
    }
}
