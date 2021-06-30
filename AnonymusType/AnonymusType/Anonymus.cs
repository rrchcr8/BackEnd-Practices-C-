using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymusType
{
    class Anonymus
    {
        public object getData()
        {
            return new { Name = "Pepe", EmailID = "pepe@gmail.com" };
        }
    }

}
