using System;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Toyota toyota = new();
            toyota.Land();
            Console.WriteLine(toyota.numberOfWheels);
            Console.WriteLine(toyota.pepopleCapacity);
            Console.WriteLine(toyota.maximunSpeedLImit);

            ElectricFlyingCar electricFlyingCar = new();
            electricFlyingCar.Land();
            electricFlyingCar.Fly();
            Console.WriteLine(electricFlyingCar.numberOfWheels);
            Console.WriteLine(electricFlyingCar.maximunHeight);
            Console.WriteLine(electricFlyingCar.pepopleCapacity);
            Console.WriteLine(electricFlyingCar.maximunSpeedLImit);

            Boeing boeing = new();
            boeing.Land();
            Console.WriteLine(boeing.maximunHeight);
            Console.WriteLine(boeing.pepopleCapacity);
            Console.WriteLine(boeing.maximunSpeedLImit);

            Boat boat = new();
            boat.Navigate();
            Console.WriteLine(boat.pepopleCapacity);
            Console.WriteLine(boat.maximunSpeedLImit);


        }
    }


    class Transport
    {
        public double maximunSpeedLImit { get; set; }
        public double pepopleCapacity { get; set; }


    }

    interface IFly
    {
        void Fly();

    }

    //public abstract class IFly {
    //      public abstract void Fly();

    //}

    interface ILand
    {
        void Land();
    }

    interface INavigate
    {
        void Navigate();
    }

    class AirTransport : Transport, IFly, ILand
    {
        public double maximunHeight { get; set; }

        public void Fly()
        {
            Console.WriteLine("I can fly");
        }

        public virtual void Land()
        {
            Console.WriteLine("I can Land and be driven short distances");
        }
    }

    class LandTransport : Transport, ILand
    {
        public double numberOfWheels { get; set; }
        
        public void Land()
        {
            Console.WriteLine("I can be handled on Land");
        }
    }


    class AquaticTransport : Transport, INavigate
    {
        public void Navigate()
        {
            Console.WriteLine("I can navigate");
        }
    }

    

    class Toyota : LandTransport
    {
        public Toyota()
        {
            numberOfWheels = 5; // 4 plus 1 of reserve
            maximunSpeedLImit = 100;
            pepopleCapacity = 5;
        }
    }
    class ElectricFlyingCar:LandTransport, IFly
    {
        public double maximunHeight = 12_000;
        public ElectricFlyingCar(){
            numberOfWheels = 4; // 4 only
            maximunSpeedLImit = 400;
            pepopleCapacity = 4;
        }

        public void Fly()
        {
            Console.WriteLine("I can fly too");
        }
    }
    class Boat:AquaticTransport
    {

        public Boat() {
            maximunSpeedLImit = 400;
            pepopleCapacity = 4;
        }
    }
    class Boeing :AirTransport
    {
        public Boeing() {
            maximunSpeedLImit = 300;
            pepopleCapacity = 100;
            maximunHeight = 10_000; //setting max height, because its a concrete class
        }
    }



}
