using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book("The Fellowship of the Ring", "J.R.R. Tolkien", 14.95m));
            bookList.Add(new Book("Professional C# 2008", "Wrox Publishing", 39.95m));
            bookList.Add(new Book("Ender's Game", "Orson Scott Card", 7.95m));
            bookList.Add(new Book("Dracula", "Bram Stoker", 19.95m));
            bookList.Add(new Book("The Two Towers", "J.R.R. Tolkien", 14.95m));
            bookList.Add(new Book("Wicked", "Gregory Maguire", 14.95m));
            bookList.Add(new Book("Brave New World", "Aldous Huxley", 9.95m));
            bookList.Add(new Book("Return of the King", "J.R.R. Tolkien", 14.95m));
            bookList.Add(new Book("Hyperion", "Dan Simmons", 6.95m));
            bookList.Add(new Book("The Fall of Hyperion", "Dan Simmons", 6.95m));

            var displayList = from book in bookList
                              orderby book.Title ascending
                              select book;
            Console.WriteLine("Books Alphabetically By Title:");
            Console.WriteLine("--------------------------------------------------------");
            foreach( var book in displayList)
            {
                Console.WriteLine("{0,-35} {1}", book.Title, book.Author);
            }
            Console.WriteLine("\nPress any key...\n");
            Console.ReadKey();

            var displayList2 = from book in bookList
                               orderby book.Author ascending, book.Title ascending
                               select book;
            Console.WriteLine("Books Alphabetically By Author, Then Title:");
            Console.WriteLine("--------------------------------------------------------");
            foreach (var book in displayList2)
            {
                Console.WriteLine("{0,-35} {1}", book.Author, book.Title);
            }
            Console.WriteLine("\nPress any key...\n");
            Console.ReadKey();           

            var displayList3 = from book in bookList 
                               where book.Price < 10m                              
                               orderby book.Title ascending                               
                               select book;
            Console.WriteLine("Books Less Than $10, Alphabetically By Title:");
            Console.WriteLine("--------------------------------------------------------");
            foreach (var book in displayList3)
            {
                Console.WriteLine("{0,-5} {1,-30}{2}", book.Price, book.Title, book.Author);
            }
            var displayList4 = from book in bookList
                               where book.Price >= 10m && book.Price < 20m
                               orderby book.Title ascending
                               select book;
            Console.WriteLine("\nBooks From $10 To $20, Alphabetically By Title:");
            Console.WriteLine("--------------------------------------------------------");
            foreach (var book in displayList4)
            {
                Console.WriteLine("{0,-5} {1,-30}{2}", book.Price, book.Title, book.Author);
            }
            var displayList5 = from book in bookList
                               where book.Price >= 20m
                               orderby book.Title ascending
                               select book;
            Console.WriteLine("\nBooks More Than $20, Alphabetically By Title:");
            Console.WriteLine("--------------------------------------------------------");
            foreach (var book in displayList5)
            {
                Console.WriteLine("{0,-5} {1,-30}{2}", book.Price, book.Title, book.Author);
            }

            Console.WriteLine("\nPress any key...\n");
            Console.ReadKey();            
        }
    }
}
