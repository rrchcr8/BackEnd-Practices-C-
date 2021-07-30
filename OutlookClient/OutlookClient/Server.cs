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
        List<Account> accounts { get; set; }

        public SMTPServer() {
            
            this.accounts = new() { };
        }
        
        private void AddAccount(Account account) {
            var flag = false;
            foreach (Account a in accounts) {
                if (a.emailAdress.Equals(account.emailAdress)) {
                    flag = true;
                }
            }
            if (flag)
            {
                Console.WriteLine("email address already exists!");
            }
            else {
                this.accounts.Add(account);
            }
               
              
                  
        }

        private void ProccessMail(Message message) { 
        }

        
    }
}
