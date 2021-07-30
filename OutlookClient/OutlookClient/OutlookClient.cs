using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookClient
{
    public class OutlookClient:IClient

    {
        private SMTPServer SMTPServer;
        
        public Account Account { get; }
        
        public List<Folder> folders { get; set; }

        public OutlookClient(Account account, SMTPServer server) {
            Account = account;
            SMTPServer = server;

            SMTPServer.Suscribe(receive);
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
        public Message CreateMessage(String emailDestination, string content, string subject) {

            Account a = SMTPServer.accounts.Find(x=> x.emailAdress==emailDestination);
            Message message = new Message(Account, new List<Account> { a},subject, content );
            return message;
        }

        public void send(Message message)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("sent message from {0}: ", Account.emailAdress);
            Console.WriteLine("Sent message To {0}: ", message.to[0].emailAdress);
            Console.WriteLine("sent message Subject {0}: ", message.subject);
            Console.WriteLine("sent message BODY {0}: ", message.body);
            SMTPServer.Send(message);
        }

        public void receive(Message message)
        {
            if (message.to.Contains(Account)) {
                var inbox = this.folders.Find(x => x.FolderName == "inbox");
                inbox.Content.Add(message);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ACCOUNT THAT received THE message :: {0} ", Account.emailAdress);
                Console.WriteLine("received message from {0}: ", message.From.emailAdress);
                Console.WriteLine("received message SUBJECT {0}: ", message.subject);
                Console.WriteLine("received message BODY {0}: ", message.body);
            }
            

        }
    }
}
