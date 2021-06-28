using System;

namespace GenericsExercise
{
    class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
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

            // where T : new()	The type argument must have a public parameterless constructor

            MyGenerics<PrivateClass> pi = new();
            MyGenerics<string> sss = new();
            MyGenerics<PublicClass> p2 = new();

            // where T : struct

            // all this tipe are non nullaBLE TYPES
            GenericsStructRestrains<StrucClass> qw = new();
            GenericsStructRestrains<int> qw2 = new();
            GenericsStructRestrains<double> qw1233 = new();

            //must be a non nullable type
            GenericsStructRestrains<String> qw2 = new();
            GenericsStructRestrains<PublicClass> qw3 = new();



        }


        // where T : new()
        public class MyGenerics<T> where T : new()
        {
        }

        public class PrivateClass
        {

            private PrivateClass()
            {
            }

        }
    }

    public class PublicClass
    {

        public PublicClass()
        {
        }

    }

    public class GenericsStructRestrains<T> where T : struct { 
    }

    struct StrucClass { 
    
    }


}

