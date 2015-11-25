using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSST.Cloud
{
    public class LinkUsageEventArgs : EventArgs
    {
        private string sourceId;
        public string SourceId { get { return sourceId; } }

        private string destinationId;
        public string DestinationId { get { return destinationId; } }

        private bool isSuccessful;
        public bool IsSuccessful { get { return isSuccessful; } }

        public LinkUsageEventArgs (string aSourceId, string aDestinationId, bool succeded)
        {
            this.destinationId = aDestinationId;
            this.sourceId = aSourceId;
            this.isSuccessful = succeded;
        }

    }
}
