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

            OutlookClient CarlosOutlookClient = new OutlookClient(CarlosAccount,server);
            OutlookClient LauraOutlookClient = new OutlookClient(LauraAccount, server);

            Console.WriteLine("initial count of items in inbox");
            Console.WriteLine(LauraOutlookClient.folders[0].FolderName);
            Console.WriteLine(LauraOutlookClient.folders[0].Content.Count);

            //crichter creates a messagge
            Message message = CarlosOutlookClient.CreateMessage("lrod@jala.com","content test", "PRUEBA ONE");
            CarlosOutlookClient.send(message);

            Console.WriteLine("after receiving an email");
            Console.WriteLine(LauraOutlookClient.folders[0].FolderName);
            Console.WriteLine(LauraOutlookClient.folders[0].Content.Count);


            Console.WriteLine("Now we will try to send a message that contains CF Bolivar");
            Message messageNasty = CarlosOutlookClient.CreateMessage("lrod@jala.com", "this is a body that contains the forbidden word CF Bolivar", "PRUEBA polity");
            CarlosOutlookClient.send(messageNasty);

            Console.WriteLine("after receiving the second email");
            Console.WriteLine("folder name: {0} ", LauraOutlookClient.folders[0].FolderName);
            Console.WriteLine("Count:  {0}", LauraOutlookClient.folders[0].Content.Count);
            Console.WriteLine("mail  {0}", LauraOutlookClient.folders[0].Content[1]);


            //creates a folder
            CarlosOutlookClient.CreateFolder("spam");
            CarlosOutlookClient.CreateFolder("personal");
            CarlosOutlookClient.RemoveFolder("spam");
           





        }
    }
}
