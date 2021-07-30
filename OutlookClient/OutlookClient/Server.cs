using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookClient
{
    public class SMTPServer
    {
        private string domainName; 
        List<OutlookClient> outlookClients { get; set; }

        public SMTPServer(string domainName ) {
            this.domainName = domainName;
            this.outlookClients = new() { };
        }
        
        private void SuscribeClient(OutlookClient outlookClient) {
            this.outlookClients.Add(outlookClient);
        
        }

        private void ProccessMail(Message message) { 
        }
    }
}
