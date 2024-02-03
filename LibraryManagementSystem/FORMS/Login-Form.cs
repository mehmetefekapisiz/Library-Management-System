using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem.FORMS
{
    public partial class Login_Form : Form
    {
        string conString = "Data Source=DESKTOP-J9OU9EE\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public Login_Form()
        {
            InitializeComponent();
        }

        private bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE user_username=@Username AND user_password=@Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (AuthenticateUser(username, password))
            {
                FORMS.Dashboard_Form dashboardForm = new FORMS.Dashboard_Form();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }
    }
}
