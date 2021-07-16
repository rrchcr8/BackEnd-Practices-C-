using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;



namespace LINQthreats
{
    class Program
    {
        public static int Price { get; private set; }
        public static int Id { get; private set; }

        static void Main(string[] args)
        {

            //var watch = new Stopwatch();
            //Console.WriteLine("press enter to start");
            //Console.ReadLine();
            //watch.Start();

            //IEnumerable<int> numbers = Enumerable.Range(1, 2_000_000_000);
            ////var squares = numbers.Select(number => number * number).ToArray();
            //var squares = numbers.AsParallel().Select(number => number * number).ToArray();
            //watch.Stop();
            //Console.WriteLine("{0:#,##0}elapsed miliseconds.",arg0: watch.ElapsedMilliseconds);

            List<Product> people = new List<Product>() {
                new Product()  { Id = 1, Price = 35 },
                new Product()  { Id = 2, Price = 150 },
                new Product()  { Id = 3, Price = 650 },
                new Product()  { Id = 4, Price = 150 },
                new Product()  { Id = 4, Price = 15 },
                new Product()  { Id = 5, Price = 35 },
                new Product()  { Id = 6, Price = 650 },
                new Product()  { Id = 8, Price = 78 },
                new Product()  { Id = 9, Price = 35 },
                new Product()  { Id = 10, Price = 78 },
            };

            Console.WriteLine(people.Average(p => p.Price));
            Console.WriteLine(people.Mode(p => p.Price));
            Console.WriteLine(people.Median(p => p.Price));
            Console.WriteLine(people.LessCommon(p => p.Price));


        }



    }
}
