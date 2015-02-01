using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walk_in_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            WalkInLibrary walkInLibrary = new WalkInLibrary();

            // Add some books to the library and print out the Book table to console
            Book nutmegBook = new Book();
            nutmegBook.Title = "Nutmeg Cookbook: All About the Nutmeg";

            walkInLibrary.AddBook(nutmegBook);

            walkInLibrary.PrintBooksTable();

            // Modify some books in the library and print out the Book table to console


            // Remove some books in the library and print out the Book table to console



            Console.ReadLine();
        }
    }
}
