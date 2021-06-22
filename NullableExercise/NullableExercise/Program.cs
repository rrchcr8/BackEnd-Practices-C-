using System;

namespace NullableExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> nx = new Nullable<int>();
            //int? nx = null;
            int x=6;
            
            
            Console.WriteLine("nx has a value? {0}", nx.HasValue);
            Console.WriteLine("x == nx: {0}", x == nx);
            Console.WriteLine("x != nx: {0}", x != nx);


            nx = 20;
            x = 5;

            Console.WriteLine("nx has a value? {0}", nx.HasValue);
            Console.WriteLine("nx has a value? {0}", nx.Value);
            Console.WriteLine("x == nx: {0}", x == nx);
            Console.WriteLine("x != nx: {0}", x != nx);

            nx = null;
            Console.WriteLine("nx = {0}", nx ?? -1);
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault());
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault(-2));
            
            
            


            //Console.WriteLine("nx has a value? {0}", nx.HasValue);
            //Console.WriteLine("nx has a value? {0}", nx.HasValue);
            //Console.WriteLine("nx has a value? {0}", nx.HasValue);
            //Console.WriteLine("nx has a value? {0}", nx.HasValue);
            //Console.WriteLine("nx has a value? {0}", nx.HasValue);
            //Console.WriteLine("nx has a value? {0}", nx.HasValue);



        }
    }
}
