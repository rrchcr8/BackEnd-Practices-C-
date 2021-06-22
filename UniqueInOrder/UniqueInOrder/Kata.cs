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
            ////}
            //List<T> result = new List<T>();
            //var list= iterable.ToList();

            //for (int i = 0; i < iterable.Count(); i++) {
            //    if (i == 0) {
            //        result.Add(list[i]);
            //    }
            //    else if (i>0) {

            //        if (!list[i].Equals(list[i-1]))
            //        {
            //            result.Add(list[i]);
            //        }

            //    }

            //}


            //return result;

            if (iterable == null)
                return null;
            if (!iterable.Any())
                return Enumerable.Empty<T>();

            List<T> output = new List<T>();
            output.Add(iterable.First());
            T lastItem = output[0];

            foreach (T item in iterable)
            {
                if (!lastItem.Equals(item))
                {
                    output.Add(item);
                    lastItem = item;
                }
            }

            return output;


        }
    }
}
