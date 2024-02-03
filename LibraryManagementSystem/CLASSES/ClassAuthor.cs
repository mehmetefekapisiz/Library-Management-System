using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem.CLASSES
{
    internal class ClassAuthor
    {
        private string conString = "Data Source=DESKTOP-J9OU9EE\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public int author_id { get; set; }
        public string author_firstname { get; set; }
        public string author_lastname { get; set; }

        public DataTable GetAuthors()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT * FROM authors";
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

        public int GetTotalAuthorCount()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM authors";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void AddAuthor(string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "INSERT INTO authors (author_firstname, author_lastname) VALUES (@author_firstname, @author_lastname)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@author_firstname", firstName);
                    command.Parameters.AddWithValue("@author_lastname", lastName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditAuthor(int authorID, string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "UPDATE authors SET author_firstname = @author_firstname, author_lastname = @author_lastname WHERE author_id = @author_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@author_id", authorID);
                    command.Parameters.AddWithValue("@author_firstname", firstName);
                    command.Parameters.AddWithValue("@author_lastname", lastName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAuthor(int authorID)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "DELETE FROM authors WHERE author_id = @author_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@author_id", authorID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}