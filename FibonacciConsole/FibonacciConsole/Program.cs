using System;
using System.Collections.Generic;

namespace FibonacciConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Fibonacci(5);
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }


        }
        static List<int> Fibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            List<int> result = new() { n1, n2 };

            while (result.Count < n)
            {
                n1 = result[^1];
                n2 = result[^2];

                result.Add(n1 + n2);
            }

            return result;
        }
    }
}
//0 1 1 2 3 5