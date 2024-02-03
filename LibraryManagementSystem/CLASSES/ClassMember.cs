using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem.CLASSES
{
    internal class ClassMember
    {
        private string conString = "Data Source=DESKTOP-J9OU9EE\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public int member_id { get; set; }
        public string member_firstname { get; set; }
        public string member_lastname { get; set; }
        public string member_gender { get; set; }
        public string member_phone { get; set; }
        public string member_email { get; set; }

        public DataTable GetMembers()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT * FROM members";
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

        public int GetTotalMemberCount()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM members";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void AddMember(string firstName, string lastName, string gender, string phone, string email)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "INSERT INTO members (member_firstname, member_lastname, member_gender, member_phone, member_email) VALUES (@member_firstname, @member_lastname, @member_gender, @member_phone, @member_email)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@member_firstname", firstName);
                    command.Parameters.AddWithValue("@member_lastname", lastName);
                    command.Parameters.AddWithValue("@member_gender", gender);
                    command.Parameters.AddWithValue("@member_phone", phone);
                    command.Parameters.AddWithValue("@member_email", email);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditMember(int memberID, string firstName, string lastName, string gender, string phone, string email)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "UPDATE members SET member_firstname = @member_firstname, member_lastname = @member_lastname, member_gender = @member_gender, member_phone = @member_phone, member_email = @member_email WHERE member_id = @member_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@member_id", memberID);
                    command.Parameters.AddWithValue("@member_firstname", firstName);
                    command.Parameters.AddWithValue("@member_lastname", lastName);
                    command.Parameters.AddWithValue("@member_gender", gender);
                    command.Parameters.AddWithValue("@member_phone", phone);
                    command.Parameters.AddWithValue("@member_email", email);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteMember(int memberID)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "DELETE FROM members WHERE member_id = @member_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@member_id", memberID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
