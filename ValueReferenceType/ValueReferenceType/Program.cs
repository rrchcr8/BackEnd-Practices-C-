using System;
using System.Collections.Generic;

namespace ValueReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {

            var n1 = new DetailedInteger(0);
            n1.AddDetail("A");
            Console.WriteLine(n1); //0 [A]

            var n2 = n1;
            n2.Number = 7;
            n2.AddDetail("B");

            Console.WriteLine(n1); //0 [A, B]
            Console.WriteLine(n2); //7 [A, B] 

        }
    }

    class DetailedInteger
    {
        public int Number;
        List<string> Array = new List<string>();
        

        public DetailedInteger(int Number)
        {
            this.Number = Number;
        }

        internal void AddDetail(string v)
        {
            Array.Add(v);
        }

        public override string ToString() {
            string n3 = Number.ToString();
            return String.Join(n3, Array);
                }


    }
}
