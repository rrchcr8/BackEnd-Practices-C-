using System;

namespace GenericsConstrain
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.Unique.name = "pepe";
            Console.WriteLine(Person.Unique.name);
        }
    }
    public class UniquePerson<T> where T: new()
    {
        public static T Unique = new();
        
    }

    public class Person : UniquePerson<Person>
    {
        public string name;


    }


}
