using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExercise
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int Description { get; set; }
        public virtual ICollection<Product> products { get; set; }


        public Category() {

            this.products = new HashSet<Product>();
        }
    
    }
}
