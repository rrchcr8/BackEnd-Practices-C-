using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person[] people =
            //{

            //new Person {Name = "Simon" },
            //new Person {Name = "Jenny" },
            //new Person {Name = "Adam" },
            //new Person {Name = "Richard" }
            //};

            //Console.WriteLine("Initial List of peole:");
            //foreach (var person in people)
            //{

            //    Console.WriteLine($"{person.Name}");
            //}
            //Console.WriteLine("Use Person's Icomparable implementation to sort");
            ////Array.Sort(people);
            //Array.Sort(people, new PersonComparer());
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"{person.Name}");
            //}

            IPlayable player = new DvdPlayer();
            player.Stop();
            IPlayable player2 = new Mp3Player();
            player2.Stop();

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



    public interface IPlayable 
    {
        void Play();
        void Pause();
        void Stop()
        {
            Console.WriteLine("default impementation for all the classes");
        }
    }

    public class DvdPlayer : IPlayable
    {
       public void Pause()
        {
            Console.WriteLine("DVD player is now pausing");
        }

        public void Play()
        {
            Console.WriteLine("DVD player is now playing");
        }


    }


    public class Mp3Player : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("DVD player is now pausing");
        }

        public void Play()
        {
            Console.WriteLine("DVD player is now playing");
        }

        public void Stop() {
            Console.WriteLine("OVERRIDING DVD player is now playing");
        }


    }

}

