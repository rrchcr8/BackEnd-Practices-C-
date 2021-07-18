using System;

namespace DelegatesBasics
{
    class Program
    {
        private delegate int MyDelegate(string input);
        
       static void Main(string[] args)
        {
            Program program = new();

            MyDelegate myDelegate = new MyDelegate(MethodIWantToCall);
            Console.WriteLine(myDelegate("Test123"));
            
        }

        public static int MethodIWantToCall(string input) {

            return input.Length;
        }
    
    }
}
