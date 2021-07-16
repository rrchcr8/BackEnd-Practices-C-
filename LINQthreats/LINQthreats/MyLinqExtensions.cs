using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq
{
    public static class MyLinqExtensions
    {
        public static IEnumerable<T> ProcessSequence<T>(this IEnumerable<T> sequence) {
            return sequence;
        }
        public static int? Median(this IEnumerable<int?> sequence) {
            var ordered = sequence.OrderBy(item=>item);
            int middlePosition = ordered.Count() / 2;
            return ordered.ElementAt(middlePosition);
      
        }


        public static int? Median<T>(this IEnumerable<T> sequence, Func<T,int?> selector)
        {
            
            return sequence.Select(selector).Median();

        }


        public static int? Mode(this IEnumerable<int?> sequence)
        {
            int result=0;
            int major=0;
            Dictionary<int, int> myDict = new();

            foreach (var item in sequence) {
                if (!myDict.ContainsKey(item.Value)) {
                    myDict.Add(item.Value, 1);
                }
                else {
                    myDict[item.Value] = myDict[item.Value] + 1;
                }
            }                    
                        
            
            foreach (KeyValuePair<int, int> kvp in myDict)
            {
                if (kvp.Value > major)
                {
                    major = kvp.Value;
                    result = kvp.Key;
                }

            }


            return result;
        }


        public static int? Mode<T>(this IEnumerable<T> sequence, Func<T, int?> selector)
        {

            return sequence.Select(selector).Mode();

        }

        public static int? LessCommon(this IEnumerable<int?> sequence)
        {
            int result = 0;
            int minor = 12345555;
            Dictionary<int, int> myDict = new();

            foreach (var item in sequence)
            {
                if (!myDict.ContainsKey(item.Value))
                {
                    myDict.Add(item.Value, 1);
                }
                else
                {
                    myDict[item.Value] = myDict[item.Value] + 1;
                }
            }


            foreach (KeyValuePair<int, int> kvp in myDict)
            {
                if (kvp.Value < minor)
                {
                    minor = kvp.Value;
                    result = kvp.Key;
                }

            }


            return result;
        }


        public static int? LessCommon<T>(this IEnumerable<T> sequence, Func<T, int?> selector)
        {

            return sequence.Select(selector).LessCommon();

        }





    }
}
