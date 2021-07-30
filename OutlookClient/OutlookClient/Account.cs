using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookClient
{
    public class Account
    {
        public int FirstName { get; set; }
        public int SecondName { get; set; }
        public string Username { get; set; }
        public string emailAdress { get; set; }
        public int password { get; set; }

        public Account(int firstName, int secondName, string username, string emailAdress, int password)
        {
            FirstName = firstName;
            SecondName = secondName;
            Username = username;
            this.emailAdress = emailAdress;
            this.password = password;
        }

    }
}
