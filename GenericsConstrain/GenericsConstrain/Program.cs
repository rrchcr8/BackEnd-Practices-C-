using System;

namespace GenericsConstrain
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.Unique.name = "pepe";
            Console.WriteLine(Person.Unique);
            Console.WriteLine(Person.Unique.name);

            Person.Unique.name = "pedro";
            Console.WriteLine(Person.Unique);
            Console.WriteLine(Person.Unique.name);
        }
    }
    public class UniquePerson<T> where T: new()
    {
        // public static T Unique = new();
        private static T UniquePrivate;
        public static T Unique  { get => UniquePrivate == null ? UniquePrivate = new() : Unique; }

       
    }

    public class Person : UniquePerson<Person>
    {
        public string name;


    }


}
