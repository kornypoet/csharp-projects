using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Book : IEquatable<Book>
    {
        //Properties
        public string TitleOfBook { get; set; }
        public string AuthorName { get; set; }

        //Constructor       
        public Book(string title, string author)
        {
            TitleOfBook = title;
            AuthorName = author;
        }

        //Method overrides
        public override string ToString()
        {
            return '"' + TitleOfBook + '"' + " by " + AuthorName;
        }
        bool IEquatable<Book>.Equals(Book other)
        {
            return (AuthorName == other.AuthorName && TitleOfBook == other.TitleOfBook);                
        }        
    }
}
