using System;

namespace GenericsExercise
{
    class Program
    {
        public static void Swap<T>(ref T a, ref T b) {
            T c = a;
            a = b;
            b = c;
            }
        static void Main(string[] args)
        {
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            Console.WriteLine("Before calling swap");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("c = {0}, c = {1}", c, d);

            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);

            Console.WriteLine("After calling swap");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("c = {0}, c = {1}", c, d);

        }
    }
}
