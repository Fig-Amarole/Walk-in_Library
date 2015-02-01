using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walk_in_Library
{
    public class DatabaseWhisperer
    {
        public DatabaseWhisperer() { }

        // Add a row to Books table
        public void AddBook(Book book)
        {
            string queryString = @"
                insert into dbo.books
                values (@title)";

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseOverlordContainer"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@title", book.Title);

                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        
        // Update a row in Books table
        public void UpdateBook(Book book)
        {

        }

        // Delete a row in Books table
        public void DeleteBook(Book book)
        {

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            string queryString = "select * from dbo.books";

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseOverlordContainer"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand(queryString, connection)))
                {
                    DataTable dataTable = new DataTable();
                    
                    try
                    {
                        sqlDataAdapter.Fill(dataTable);

                        foreach (DataRow dataRow in dataTable.Rows)
                        {
                            Book book = new Book();
                            book.Id = (int)dataRow["Id"];
                            book.Title = (string)dataRow["Title"];

                            output.AppendLine(book.ToString());
                        }
                    }
                    catch (Exception exception)
                    {
                        return exception.Message;
                    }
                }
            }

            return output.ToString();
        }
    }
}
