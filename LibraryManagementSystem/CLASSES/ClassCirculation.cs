using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem.CLASSES
{
    internal class ClassCirculation
    {
        private string conString = "Data Source=DESKTOP-J9OU9EE\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public int book_id { get; set; } // foreign key
        public int member_id { get; set; } // foreign key
        public string statue { get; set; }

        public bool IsBookAvailable(int bookID)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM circulations WHERE book_id = @book_id AND statue = 'Issued'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@book_id", bookID);
                    int count = (int)command.ExecuteScalar();
                    return count == 0;
                }
            }
        }

        public List<string> GetIssuedBooksByMember(int memberID)
        {
            List<string> issuedBooks = new List<string>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT b.book_title FROM circulations c INNER JOIN books b ON c.book_id = b.book_id WHERE c.member_id = @member_id AND c.statue = 'Issued'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@member_id", memberID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bookTitle = reader["book_title"].ToString();
                            issuedBooks.Add(bookTitle);
                        }
                    }
                }
            }
            return issuedBooks;
        }

        public bool IsBookIssued(int bookID)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM circulations WHERE book_id = @book_id AND statue = 'Issued'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@book_id", bookID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void IssueBook(int bookID, int memberID)
        {
            if (!MemberExists(memberID))
            {
                MessageBox.Show("Member does not exist. Please enter a valid member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!BookExists(bookID))
            {
                MessageBox.Show("Book does not exist. Please enter a valid book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsBookIssued(bookID))
            {
                MessageBox.Show("This book is already issued.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO circulations (book_id, member_id, statue) VALUES (@book_id, @member_id, 'Issued')";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@book_id", bookID);
                    insertCommand.Parameters.AddWithValue("@member_id", memberID);
                    insertCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Book issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void ReturnBook(int bookID, int memberID)
        {
            if (!MemberExists(memberID))
            {
                MessageBox.Show("Member does not exist. Please enter a valid member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!BookExists(bookID))
            {
                MessageBox.Show("Book does not exist. Please enter a valid book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsBookIssued(bookID))
            {
                MessageBox.Show("This book is not currently issued.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string updateQuery = "UPDATE circulations SET statue = 'Returned' WHERE book_id = @book_id AND member_id = @member_id AND statue = 'Issued'";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@book_id", bookID);
                    updateCommand.Parameters.AddWithValue("@member_id", memberID);
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to return the book. It may not be issued to the specified member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private bool MemberExists(int memberID)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM members WHERE member_id = @member_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@member_id", memberID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
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
    }
}