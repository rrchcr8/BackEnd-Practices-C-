using System;

namespace DelegatesExercise
{
   
    class Program
    {
        


        static void Main(string[] args)
        {
            Expresion expresion = new(20, 10);
            var result = expresion.ApplyOperator(Operation.Sum);
            Console.WriteLine($"Resut adition: {result}");
            var resultSubs = expresion.ApplyOperator(Operation.Substract);
            Console.WriteLine($"Resut substraction: {resultSubs}");
        }
    }

    public class Expresion
    {
        public delegate int OpDelegate();
        private int first;
        private int second;

        public Expresion(int first, int second) {
            this.first = first;
            this.second = second;
        }

        private int Sum()
        {
            return first + second;
        }

        private int Substract()
        {
            return first - second;
        }

        private int Multiply()
        {
            return first * second;
        }

        public int ApplyOperator(Operation operation) 
        {
            OpDelegate opDelegate;
            switch (operation)
            {
                case Operation.Sum:
                    //return Sum();
                    opDelegate = new OpDelegate(Sum);
                    return opDelegate();
                case Operation.Substract:
                    opDelegate = new OpDelegate(Substract);
                    return opDelegate();
                //return Substract();
                case Operation.Multiply:
                    opDelegate = new OpDelegate(Multiply);
                    return opDelegate();
                //return Multiply();
                default:
                    return 0;
            }

        }


    }
    public enum Operation
    {
        Sum,
        Substract,
        Multiply
    }



}
