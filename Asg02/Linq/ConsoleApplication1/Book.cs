using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Book (string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }
        public int CompareTo(Book other)
        {
            return this.Title.CompareTo(other.Title);
        }
    }
}
