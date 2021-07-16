using System;
using System.Linq;

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

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var lowNums = from num in numbers
            //              where num < 5
            //              select num;

            //Console.WriteLine("Numbers < 5:");
            //foreach (var x in lowNums)
            //{
            //    Console.WriteLine(x);
            //}


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
