using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walk_in_Library
{
    public class WalkInLibrary
    {
        private DatabaseWhisperer databaseWhisperer = null;
        public DatabaseWhisperer DatabaseWhisperer
        {
            get
            {
                return databaseWhisperer ?? (databaseWhisperer = new DatabaseWhisperer());
            }
        }

        public WalkInLibrary() { }

        // Add a book
        public void AddBook(Book book)
        {
            DatabaseWhisperer.AddBook(book);
        }

        // Modify a book


        // Remove a book


        // Print out the Books table to console
        // 1. Get all the entities from the Books table
        // 2. Call ToString on each entity and print it to console
        public void PrintBooksTable()
        {
            Console.WriteLine(DatabaseWhisperer.ToString());
        }
    }
}
