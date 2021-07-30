using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookClient
{
    public class SMTPServer
    {
        public delegate void DelegateSend(Message message);
        DelegateSend SendEmail;

        public List<Account> accounts { get; set; }

      
        public SMTPServer()
        {

            this.accounts = new() { };
        }

        public void Suscribe(DelegateSend method)
        {
            SendEmail += method;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----Suscribed---------");
        }

        public void Send(Message message) {

            //BAD WORD RULES
            if (message.body.Contains("CF Bolivar")) {
                message.body = message.body.Replace("CF Bolivar", "*******");
            }
            
            // Send message via delegate

            SendEmail(message);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----Message sent---------");

        }

        public void AddAccount(Account account)
        {
            var flag = false;
            foreach (Account a in accounts)
            {
                if (a.emailAdress.Equals(account.emailAdress))
                {
                    flag = true;
                }
            }
            if (flag)
            {
                Console.WriteLine("email address already exists!");
            }
            else
            {
                this.accounts.Add(account);
            }


        }

   


    }
}
