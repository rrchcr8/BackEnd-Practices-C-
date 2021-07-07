using System;

namespace DelegatesExercise
{
    class Program
    {
        private delegate int MyDelegate(string input);


        static void Main(string[] args)
        {
            Expresion expresion = new(20, 10);
            var result = expresion.ApplyOperator(Operation.Sum);
            Console.WriteLine($"Resut: {result}");
        }
    }

    public class Expresion
    {
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
            switch (operation)
            {
                case Operation.Sum:
                    return Sum();
                case Operation.Substract:
                    return Substract();
                case Operation.MUltiply:
                    return Multiply();
                
            }
        }
    }

    public class Operation
    {
       

    }


}
