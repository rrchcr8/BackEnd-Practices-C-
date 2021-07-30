using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookClient
{
    public class Message
    {
        public String IpOrigin { get; set; }
        public Account From { get; set; }

        public List<Account> to { get; set; }

        public String subject { get; set; }

        public List<Account> CC { get; set; }

        public String body { get; set; }
        public DateTime date { get; set; }


    }
}
