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
            //Console.WriteLine(nameof(n1)); // n1
            Console.WriteLine(n1); //0 [A]

            var n2 = n1;
            n2.Number = 7;
            
            n2.AddDetail("B");

            //Console.WriteLine(nameof(n1)); //n1
            Console.WriteLine(n1); //0 [A, B]
            //Console.WriteLine(nameof(n2)); //n2 
            Console.WriteLine(n2); //7 [A, B] 

        }
    }

    struct DetailedInteger
    {

        public int Number;
        public List<string> Arr;
        

        public DetailedInteger(int Number)
        {
            this.Number = Number;
            Arr = new List<string>();
                       
            
        }

        internal void AddDetail(string v)
        {
            Arr.Add(v);
        }

        public override string ToString() {
            return Number + " [" + String.Join(", ", Arr) + "]";
            //if (nameof(d).Equals("n1"))
            //{
            //    return d.Number + " [" + String.Join(", ", Arr) + "]";
            //}
            //else { return Number + " [" + String.Join(", ", Arr) + "]"; }
        }


    }
}
