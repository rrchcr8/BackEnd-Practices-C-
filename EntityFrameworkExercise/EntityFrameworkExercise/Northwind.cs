using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExercise
{
    class Northwind: DbContext
    {
        //this properties map to tables in the database
        public int BbSet<Category> Categories { get; set; }
        public int BbSet<Product> Products { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(
                System.Environment.CurrentDirectory,"Northwind.db"
                );
            optionsBuilder.UseSqlite($"Filename={path}");     
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
        
            modelBuilder.Entity<Category>().Property(Category =>)
        }


    }
}
