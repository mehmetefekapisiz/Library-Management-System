using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem.CLASSES
{
    internal class ClassBook
    {
        private string conString = "Data Source=DESKTOP-J9OU9EE\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public int book_id { get; set; }
        public string book_isbn { get; set; }
        public string book_title { get; set; }
        public int author_id { get; set; } // foreign key
        public int genre_id { get; set; } // foreign key
        public float book_price { get; set; }
        public string book_publisher { get; set; }
        public DateTime book_datereceived { get; set; }
        public string book_description { get; set; }
        public byte[] book_cover { get; set; }

        public DataTable GetBooks()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT * FROM books";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
        }

        public int GetTotalBookCount()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM books";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        private bool BookExists(int bookID)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM books WHERE book_id = @book_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@book_id", bookID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool AuthorExists(int authorID)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM authors WHERE author_id = @author_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@author_id", authorID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool GenreExists(int genreID)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM genres WHERE genre_id = @genre_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@genre_id", genreID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public DataTable GetBookTitlesByAuthorID(int authorID)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT book_title FROM books WHERE author_id = @author_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@author_id", authorID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("BookTitle");

                        while (reader.Read())
                        {
                            string bookTitle = reader["book_title"].ToString();
                            dataTable.Rows.Add(bookTitle);
                        }
                        return dataTable;
                    }
                }
            }
        }

        private bool IsISBNAlreadyExists(string isbn, int currentBookID = -1)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM books WHERE book_isbn = @book_isbn AND book_id != @book_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@book_isbn", isbn);
                    command.Parameters.AddWithValue("@book_id", currentBookID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void AddBook(string isbn, string title, int authorID, int genreID, float price, string publisher, DateTime dateReceived, string description, byte[] cover)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                if (!AuthorExists(authorID))
                {
                    MessageBox.Show("Invalid author ID. Please enter a valid author ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!GenreExists(genreID))
                {
                    MessageBox.Show("Invalid genre ID. Please enter a valid genre ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsISBNAlreadyExists(isbn))
                {
                    MessageBox.Show("This ISBN already exists in the system. Please enter a different ISBN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO books (book_isbn, book_title, author_id, genre_id, book_price, book_publisher, book_datereceived, book_description, book_cover) VALUES (@book_isbn, @book_title, @author_id, @genre_id, @book_price, @book_publisher, @book_datereceived, @book_description, @book_cover)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@book_isbn", isbn);
                    command.Parameters.AddWithValue("@book_title", title);
                    command.Parameters.AddWithValue("@author_id", authorID);
                    command.Parameters.AddWithValue("@genre_id", genreID);
                    command.Parameters.AddWithValue("@book_price", price);
                    command.Parameters.AddWithValue("@book_publisher", publisher);
                    command.Parameters.AddWithValue("@book_datereceived", dateReceived);
                    command.Parameters.AddWithValue("@book_description", description);
                    command.Parameters.AddWithValue("@book_cover", cover);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditBook(int bookID, string isbn, string title, int authorID, int genreID, float price, string publisher, DateTime dateReceived, string description, byte[] cover)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                if (!AuthorExists(authorID))
                {
                    MessageBox.Show("Please enter a valid author ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!GenreExists(genreID))
                {
                    MessageBox.Show("Please enter a valid genre ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsISBNAlreadyExists(isbn, bookID))
                {
                    MessageBox.Show("This ISBN already exists in the system. Please enter a different ISBN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "UPDATE books SET book_isbn = @book_isbn, book_title = @book_title, author_id = @author_id, genre_id = @genre_id, book_price = @book_price, book_publisher = @book_publisher, book_datereceived = @book_datereceived, book_description = @book_description, book_cover = @book_cover WHERE book_id = @book_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@book_id", bookID);
                    command.Parameters.AddWithValue("@book_isbn", isbn);
                    command.Parameters.AddWithValue("@book_title", title);
                    command.Parameters.AddWithValue("@author_id", authorID);
                    command.Parameters.AddWithValue("@genre_id", genreID);
                    command.Parameters.AddWithValue("@book_price", price);
                    command.Parameters.AddWithValue("@book_publisher", publisher);
                    command.Parameters.AddWithValue("@book_datereceived", dateReceived);
                    command.Parameters.AddWithValue("@book_description", description);
                    command.Parameters.AddWithValue("@book_cover", cover);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteBook(int bookID)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                if (!BookExists(bookID))
                {
                    MessageBox.Show("Invalid book ID. Please enter a valid book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "DELETE FROM books WHERE book_id = @book_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@book_id", bookID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}