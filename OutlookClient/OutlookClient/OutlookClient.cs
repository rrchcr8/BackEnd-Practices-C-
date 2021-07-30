using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookClient
{
    public class OutlookClient:IClient

    {

        public EventHandler SendEvent;
        public Account Account { get; }
        private readonly string IP;
        public List<Folder> folders { get; set; }

        public OutlookClient(Account account, string IP) {
            Account = account;
            this.IP = IP;
            this.folders = new()
            {
                new Folder("inbox"),
                new Folder("Others")
            };
        }

       


        public void CreateFolder(string name) {
            this.folders.Add(new Folder(name));
        }

        public void RemoveFolder(string name)
        {
            try
            {
          
                this.folders.Remove(this.folders.Find(x => x.FolderName == name));
                
            }
            catch (Exception)
            {

                throw;
            }
            

        }

      

        public void send(Message message)
        {
            throw new NotImplementedException();
        }

        public void receive(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
