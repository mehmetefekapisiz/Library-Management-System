using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using LibraryManagementSystem.CLASSES;

namespace LibraryManagementSystem.FORMS
{
    public partial class ManageUsers_Form : Form
    {
        private ClassUser classUser = new ClassUser();

        public ManageUsers_Form()
        {
            InitializeComponent();
            dataGridView_users.DataSource = classUser.GetUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string username = textBox4.Text;
            string password = textBox5.Text;
            classUser.AddUser(firstName, lastName, username, password);
            dataGridView_users.DataSource = classUser.GetUsers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(textBox1.Text);
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string username = textBox4.Text;
            string password = textBox5.Text;
            classUser.EditUser(userID, firstName, lastName, username, password);
            dataGridView_users.DataSource = classUser.GetUsers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(textBox1.Text);
            classUser.DeleteUser(userID);
            dataGridView_users.DataSource = classUser.GetUsers();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Gets data from Table
                DataTable usersTable = classUser.GetUsers();

                // Sets the desktop path
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "users_export.txt");

                // Writes data to text file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Writes columns of data
                    foreach (DataColumn column in usersTable.Columns)
                    {
                        writer.Write(column.ColumnName + "\t");
                    }
                    writer.WriteLine();

                    // Writes rows of data
                    foreach (DataRow row in usersTable.Rows)
                    {
                        foreach (DataColumn column in usersTable.Columns)
                        {
                            writer.Write(row[column] + "\t");
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show($"Books exported to {filePath}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
