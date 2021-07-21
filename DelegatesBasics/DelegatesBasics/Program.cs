using System;

namespace DelegatesBasics
{
    class Program
    {
        private delegate int MyDelegate(string input);
        public delegate void DisplayMessage(string input);
        public delegate int MyDelegateWithReturn(string input);


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

            //DisplayMessage displayMessage1 = ClassA.WriteInformation;
            //DisplayMessage displayMessage2 = ClassB.WriteInformation;

            //DisplayMessage delegateOperations = displayMessage1 + displayMessage2;
            //delegateOperations("HI :)");

            //DisplayMessage displayMessageWithLambda = (string input) => Console.WriteLine($" called from lambda {input}");
            //delegateOperations += displayMessageWithLambda;
            //delegateOperations("HI :'(");

            //delegateOperations = delegateOperations - displayMessage2;
            //delegateOperations("HI :)");

            //delegateOperations -= displayMessage1;
            //delegateOperations("HI :)");

            MyDelegateWithReturn myDelegate1 = ClassA.GetSize;
            MyDelegateWithReturn myDelegate2 = ClassB.GetSize;
            MyDelegateWithReturn myDelegateWithReturn = myDelegate1 + myDelegate2;
            

            //cuando hay un combinacion, solo returna el ultimo delegate
            Console.WriteLine(myDelegateWithReturn("perro"));




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

            public static int GetSize(string input)
            {
             return input.Length;

            }

        }

        class ClassB
        {

            public static void WriteInformation(string input)
            {
                Console.WriteLine($"called B class parameter {input}");

            }

            public static int GetSize(string input)
            {
                return input.Length -4;

            }


        }






    }
}
