using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem.CLASSES
{
    internal class ClassUser
    {
        private string conString = "Data Source=DESKTOP-J9OU9EE\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public int user_id { get; set; }
        public string user_firstname { get; set; }
        public string user_lastname { get; set; }
        public string user_username { get; set; }
        public string user_password { get; set; }

        public DataTable GetUsers()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT * FROM users";
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

        public void AddUser(string firstName, string lastName, string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "INSERT INTO users (user_firstname, user_lastname, user_username, user_password) VALUES (@user_firstname, @user_lastname, @user_username, @user_password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_firstname", firstName);
                    command.Parameters.AddWithValue("@user_lastname", lastName);
                    command.Parameters.AddWithValue("@user_username", username);
                    command.Parameters.AddWithValue("@user_password", password);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditUser(int userID, string firstName, string lastName, string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "UPDATE users SET user_firstname = @user_firstname, user_lastname = @user_lastname, user_username = @user_username, user_password = @user_password WHERE user_id = @user_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", userID);
                    command.Parameters.AddWithValue("@user_firstname", firstName);
                    command.Parameters.AddWithValue("@user_lastname", lastName);
                    command.Parameters.AddWithValue("@user_username", username);
                    command.Parameters.AddWithValue("@user_password", password);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(int userID)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "DELETE FROM users WHERE user_id = @user_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", userID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
