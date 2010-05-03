using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Program
    {
        static void Main()
        {
            //Collection of books
            Book b1 = new Book("Brave New World", "Aldous Huxley");        
            Book b2 = new Book("Dracula", "Bram Stoker");
            Book b3 = new Book("Wicked", "Gregory Maguire");
            Book b4 = new Book("Dracula", "Bram Stoker");
            Book b5 = new Book("The Two Towers", "J.R.R. Tolkien");
            List<Book> bookList = new List<Book> { b1, b2, b3, b4, b5 };
                        
            //Collection of strings
            String s1 = "blue";            
            String s2 = "red";            
            String s3 = "yellow";            
            String s4 = "red";            
            String s5 = "yellow";            
            String s6 = "blue";            
            String s7 = "blue";
            List<String> stringList = new List<String> { s1, s2, s3, s4, s5, s6, s7 };

            //Collection of integers           
            List<Int32> integerList = new List<Int32> 
                        { 10, 10, 10, 10 };

            //These are the blank values
            Book blankBook = new Book("", "");
            string blankString = "";
            int blankInt = 0;
            
            //Write out the collections to the screen
            Console.WriteLine("Before eliminating duplicates:\n");            
            foreach (Book book in bookList)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();
            foreach (String str in stringList)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            foreach (Int32 i in integerList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nPress a key...");
            Console.ReadKey();

            //Eliminate duplicates  with a "blank" entry           
            EliminateDuplicates(bookList, blankBook);
            EliminateDuplicates(stringList, blankString);
            EliminateDuplicates(integerList, blankInt);

            //Then write out all values excluding "blank" values
            Console.WriteLine("\nAfter eliminating duplicates:\n");
            Display(bookList, blankBook);
            Console.WriteLine();
            Display(stringList, blankString);
            Console.WriteLine();
            Display(integerList, blankInt);

            Console.ReadKey();
        }
        //Generic method to replace duplicates
        public static List<T> EliminateDuplicates<T>(List<T> list, T blankValue) where T : IEquatable<T>
        {
            for (int i = 0; i < list.Count; ++i)
            {
                //Copy value of first value in first loop
                T sub = list[i];                
                for (int x = 0; x < list.Count; x++)
                {
                    //Check validity and compare to other list members
                    if (sub != null && list[x] != null)
                    {
                        if (sub.Equals(list[x]))
                        {
                            //Replace with "blank" value
                            list[x] = blankValue;
                        }
                    }                    
                }
                //Copy value back in to list
                list[i] = sub;
            }
            return list;
        }
        //Generic method to write out all but the duplicates
        public static void Display<T>(List<T> list, T blankValue) where T : IEquatable<T>
        {
            foreach (T thing in list)
            {
                //Check for "blank" values
                if (!thing.Equals(blankValue))
                {
                    //Write out everything else
                    Console.WriteLine(thing);
                }
            }
        }
    }
}
