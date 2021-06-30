using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {

            new Person {Name = "Simon" },
            new Person {Name = "Jenny" },
            new Person {Name = "Adam" },
            new Person {Name = "Richard" }
            };

            Console.WriteLine("Initial List of peole:");
            foreach (var person in people)
            {

                Console.WriteLine($"{person.Name}");
            }
            Console.WriteLine("Use Person's Icomparable implementation to sort");
            //Array.Sort(people);
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}");
            }

        }
    }

    //class Person : IComparable<Person>
    //{
    //    public string Name { get; set; }

    //    public int CompareTo(Person obj)
    //    {
    //        return Name.CompareTo(obj.Name);
    //    }
    //}


    class Person 
    {
        public string Name { get; set; }

    }

    class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);           
        
        }
    }

}
