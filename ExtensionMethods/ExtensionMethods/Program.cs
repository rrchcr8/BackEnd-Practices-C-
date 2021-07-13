using System;

namespace ExtensionMethods
{
    class Program
    {
        /*
         * Its a way to add methods to an existing type.
         */
        static void Main(string[] args)
        {
            //Extensions.FizzBuzz(2);
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(i.FizzBuzz());
            }

        }


    }

    static class Extensions
    {
        /*
         * the first paramaeter shuld inlude this
         */
        public static string FizzBuzz(this int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (value % 3 == 0)
            {
                return "Fizz";
            }
            else if (value % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
