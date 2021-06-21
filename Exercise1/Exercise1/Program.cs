using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = -100;
            short b = -128;
            short c = 3540;
            int d = 64876;
            long e = 2147483648;
            long f = -1141583228;
            long g = -1223372036854770;
            short h = 808;
            int i = 2_000_000;
            int j = 0b_0001_1110_1000_0100_1000_0000;
            int k = 0x_001E_8480;



            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            //Exercesi 2
            Console.WriteLine("exercise 2");

            decimal l = (decimal)(Math.PI);
            double m = 1.60217657;
            decimal n = 7.8184261974584555216535342341m;


            Console.WriteLine(l);
            Console.WriteLine(m);
            Console.WriteLine(n);

        }
    }
}
