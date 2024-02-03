using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem.CLASSES
{
    internal class ClassGenre
    {
        private string conString = "Data Source=DESKTOP-J9OU9EE\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public int genre_id { get; set; }
        public string genre_name { get; set; }

        public DataTable GetGenres()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT * FROM genres";
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

        public void AddGenre(string name)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "INSERT INTO genres (genre_name) VALUES (@genre_name)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@genre_name", name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditGenre(int genreID, string name)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "UPDATE genres SET genre_name = @genre_name WHERE genre_id = @genre_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@genre_id", genreID);
                    command.Parameters.AddWithValue("@genre_name", name);
                    command.ExecuteNonQuery();
                }
            }

        }

        public void DeleteGenre(int genreID)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "DELETE FROM genres WHERE genre_id = @genre_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@genre_id", genreID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
