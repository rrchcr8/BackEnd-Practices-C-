using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookClient
{
    interface IClient
    {
        void send(Message message);
        void receive(Message message);

    }
}
