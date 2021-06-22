using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueInOrder
{
    public class Kata
    {
        

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            //ArrayList result = new(); 
            //IEnumerator e= iterable.GetEnumerator();
            //e.MoveNext();
            //foreach (var element in iterable) { 
            //element
            //}
            ArrayList result = new();
            var list= iterable.ToList();

            for (int i = 0; i < iterable.Count(); i++) {
                if (i == 0) {
                    result.Add(list[i]);
                }
                else if (i>0) {

                    if (!list[i].Equals(list[i]))
                    {
                        result.Add(list[i]);
                    }

                }

            }
            
            
            return (IEnumerable<T>)result;
        }
    }
}
