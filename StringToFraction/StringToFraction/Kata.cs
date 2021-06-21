using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToFraction
{
    public class Kata
    {
        public string toFraction(double number)
        {
            //string remainder = number.ToString();
            //string remainder = number.ToString().Split(",")[1];
            //int lenght = remainder.Length;
            //double denominator = 1 * Math.Pow(10, lenght);
            //return "0/0";

            if (Math.Round(number, 0) == number)
                return number.ToString();

            string negative = "";
            if (number < 0)
            {
                negative = "-";
                number = Math.Abs(number);
            }
            for (int d = 2; d <= 2000; d++)
                for (int n = 1; n <= 2000; n++)
                    if (Math.Abs((double)n / (double)d - number) <= 0.000000001)
                        return negative + n.ToString() + "/" + d.ToString();
            return "0/0";
        }
    }
}
