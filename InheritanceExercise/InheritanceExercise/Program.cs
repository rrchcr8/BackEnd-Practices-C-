using System;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Toyota toyota = new();
            toyota.Land();
            Console.WriteLine(toyota.numberOfWheels) ;

            ElectricFlyingCar electricFlyingCar = new();
            electricFlyingCar.Land();
            electricFlyingCar.Fly();
            Console.WriteLine(electricFlyingCar.numberOfWheels);


        }
    }


    class Transport
    {
        public double maximunSpeedLImit { get; set; }
        public double pepopleCapacity { get; set; }


    }

    interface IFly
    {
        public void Fly();

    }

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
        }
    }
    class ElectricFlyingCar:LandTransport, IFly
    {
        public ElectricFlyingCar(){
            numberOfWheels = 4; // 4 only
        }

        public void Fly()
        {
            Console.WriteLine("I can fly too");
        }
    }
    class Boat:AquaticTransport
    { 
    }
    class Boeing :AirTransport
    {
        public Boeing() {
            maximunHeight = 10_000; //setting max height, because its a concrete class
        }
    }



}
