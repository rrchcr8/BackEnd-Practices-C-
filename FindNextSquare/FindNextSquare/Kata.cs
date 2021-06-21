using System;

namespace FindNextSquare
{
    public class Kata
    {
        public static long FindNextSquare(long num)
        {
            double root = Math.Sqrt(num);
            if (root % 1 != 0)
            {
                return -1;
            }
            else {
                return (long)Math.Pow((root + 1),2); ;
            }
            
        }
    
        }
}
