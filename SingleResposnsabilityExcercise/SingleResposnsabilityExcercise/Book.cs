using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposnsabilityExcercise
{
    class Book
    {
        public string name { get; set; }
        public string authorName { get; set; }
        public int year { get; set; }
        public int price { get; set; }
        public string isbn { get; set; }

        public Book(string name, string authorName, int year, int price, string isbn) {
            this.name = name;
            this.authorName = authorName;
            this.year = year;
            this.price = price;
            this.isbn = isbn;
        }
    }
}
