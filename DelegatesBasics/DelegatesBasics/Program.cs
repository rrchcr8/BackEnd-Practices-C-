using System;

namespace DelegatesBasics
{
    class Program
    {
        private delegate int MyDelegate(string input);
        public delegate void DisplayMessage(string input);


        static void Main(string[] args)
        {
            //Program program = new();

            //MyDelegate myDelegate = new MyDelegate(MethodIWantToCall);
            //Console.WriteLine(myDelegate("Test123"));


            ////another way to invoke the method
            //Console.WriteLine(myDelegate.Invoke("Test123"));


            //DisplayMessage displayMessage = Printer;
            //UseMyDelegateAsParameter(displayMessage);

            //DisplayMessage displayMessage2 = (string input) => Console.WriteLine(input);
            //UseMyDelegateAsParameter(displayMessage2);


            //Multicast

            DisplayMessage displayMessage1 = ClassA.WriteInformation;
            DisplayMessage displayMessage2 = ClassB.WriteInformation;

            DisplayMessage delegateOperations = displayMessage1 + displayMessage2;
            delegateOperations("HI :)");
            
            DisplayMessage displayMessageWithLambda = (string input) => Console.WriteLine($" called from lambda {input}");
            delegateOperations += displayMessageWithLambda;
            delegateOperations("HI :'(");

            delegateOperations = delegateOperations - displayMessage2;
            delegateOperations("HI :)");

            delegateOperations -= displayMessage1;
            delegateOperations("HI :)");





        }

        public static int MethodIWantToCall(string input) {

            return input.Length;
        }

        public static void UseMyDelegateAsParameter(DisplayMessage displayMessage) {
            displayMessage("delegate from parameter");
        }

        public static void Printer(string input)
        {
            Console.WriteLine(input);

        }

        class ClassA
        {

            public static void WriteInformation(string input) {
                Console.WriteLine($"called A class parameter {input}");
            
            }

        }

        class ClassB
        {

            public static void WriteInformation(string input)
            {
                Console.WriteLine($"called B class parameter {input}");

            }

        }






    }
}
