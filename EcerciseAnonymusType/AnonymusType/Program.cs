using System;

namespace AnonymusType
{
    class Program
    {
        static void Main(string[] args)
        {
            Anonymus anonymus = new Anonymus();
            dynamic anonymusDynamicData = anonymus.getData();
            Console.WriteLine(String.Format("{0} {1}", anonymusDynamicData.Name, anonymusDynamicData.EmailID));

            object anonymusData = anonymus.getData();
            var obj = new { Name = "", EmailID =""};
            obj = Cast(obj, anonymusData);
            Console.WriteLine(String.Format("{0} {1}", obj.Name, obj.EmailID));
            //Console.WriteLine(String.Format("{0} {1}", anonymusData.Name, anonymus.EmailID));


            var v = new { Amount = 108, Message = "Hello" };

            // Rest the mouse pointer over v.Amount and v.Message in the following
            // statement to verify that their inferred types are int and string.
            Console.WriteLine(v.Amount + v.Message);

        }

        //public object getData() {
        //    return new { Name = "Pepe", EmailID = "dsfsd@gato.com" };
        //}

        private static T Cast<T>(T typeHolder, Object x) 
        {
            return (T)x;
        }
    
    }
}
