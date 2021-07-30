using System;

namespace OutlookClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the instance of a server
            
            SMTPServer server = new SMTPServer();

            //create two instances of an account

            Account CarlosAccount = new Account("Carlos", "Richter", "crichter", "crichter@jala.com","1234" );
            Account LauraAccount = new Account("laura", "rodriguez", "lrod", "lrod@jala.com","1234" );

            //add the accounts to the server
            server.AddAccount(CarlosAccount);
            server.AddAccount(LauraAccount);

            //create instance clients

            OutlookClient CarlosOutlookClient = new OutlookClient(CarlosAccount,"127.0.0.1");
            OutlookClient LauraOutlookClient = new OutlookClient(LauraAccount,"192.168.0.10");

            //creates a folder
            CarlosOutlookClient.CreateFolder("spam");
            CarlosOutlookClient.CreateFolder("personal");
            CarlosOutlookClient.RemoveFolder("spam");
           





        }
    }
}
