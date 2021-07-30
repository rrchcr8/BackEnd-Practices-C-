using System;
using System.Linq;

namespace EntityFrameworkExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new Northwind();
            IQueryable<Category> categories = db.Categories.Include();

        }
    }
}
