using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookClient
{
    public class Account
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Username { get; set; }
        public string emailAdress { get; set; }
        public string password { get; set; }

        public Account(string firstName, string secondName, string username, string emailAdress, string password)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Username = username;
            this.emailAdress = emailAdress;
            this.password = password;
        }

    }
}
