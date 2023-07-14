using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace LibraryProject.Workspace.Classes
{
    public class Library
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""\\esher.ac.uk\home\Students\2022\221515\Visual Studio 2022\ProgrammingProjects\LibraryProject - MAIN - 16012023\LibraryProject\LibraryProject\Workspace\SQL Database\LibraryDatabase.mdf"";Integrated Security=True";
        public Library()
        {

        }

        internal List<Author> GetAuthors()
        {
            throw new NotImplementedException();
        }

        internal List<Book> SearchBook(string ISBN, string title, string authorName)
        { 
            List<Book> books = new List<Book>();
            SqlConnection LibrarySqlConnection = new SqlConnection(connectionString);

            using (LibrarySqlConnection)
            {
                LibrarySqlConnection.Open();

                using (SqlCommand searchBooksCmd = new SqlCommand($"SELECT Books.ISBN, Title, Description, Authors.AuthorID, Authors.FullName FROM Books INNER JOIN BookAuthors ON BookAuthors.ISBN = Books.ISBN INNER JOIN Authors ON BookAuthors.AuthorID = Authors.AuthorID WHERE Title LIKE '%' + @Title + '%' AND Books.ISBN LIKE '%' + @ISBN + '%' AND Authors.FullName Like '%' + @Author + '%'", LibrarySqlConnection))
                {
                    // SQL PARAMETER INITIALISATION
                    SqlParameter sqlParameterTitle = new SqlParameter("@Title", title);
                    SqlParameter sqlParameterISBN = new SqlParameter("@ISBN", ISBN);
                    SqlParameter sqlParameterAuthor = new SqlParameter("@Author", authorName);
                    //SQL PARAMETER ADDITION
                    searchBooksCmd.Parameters.Add(sqlParameterTitle);
                    searchBooksCmd.Parameters.Add(sqlParameterISBN);
                    searchBooksCmd.Parameters.Add(sqlParameterAuthor);
                    //EXECUTE DATA READER
                    SqlDataReader myDataReader = searchBooksCmd.ExecuteReader();

                    if (myDataReader.HasRows)
                    {
                        while (myDataReader.Read())
                        {
                            string foundISBN = myDataReader[0].ToString();
                            string foundTitle = myDataReader[1].ToString();
                            string foundDescription = myDataReader[2].ToString();
                            int foundAuthorID = int.Parse(myDataReader[3].ToString());
                            string foundAuthorFullname = myDataReader[4].ToString();

                            books.Add(new Book(foundISBN, foundTitle, foundDescription, new List<Author>() { new Author(foundAuthorID, foundAuthorFullname) }));
                        }
                    }
                    myDataReader.Close();

                }
                LibrarySqlConnection.Close();
            }

            return books;
        }
    }
}
