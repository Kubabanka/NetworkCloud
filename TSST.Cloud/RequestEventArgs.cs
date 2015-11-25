using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSST.Cloud
{
    public class RequestEventArgs : EventArgs
    {
        private string id;
        public string Id { get { return id; } }
        private string data;
        public string Data { get { return data; } }

        public RequestEventArgs(string id, string data)
        {
            this.id = id;
            this.data = data;
        }
    }
}
