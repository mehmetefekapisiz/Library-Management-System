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
    public partial class ManageAuthors_Form : Form
    {
        private ClassAuthor classAuthor = new ClassAuthor();
        private ClassBook classBook = new ClassBook();
        private Dashboard_Form dashboardForm;

        public ManageAuthors_Form()
        {
            InitializeComponent();
            dataGridView_authors.DataSource = classAuthor.GetAuthors();
            dashboardForm = new Dashboard_Form();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            classAuthor.AddAuthor(firstName, lastName);
            dataGridView_authors.DataSource = classAuthor.GetAuthors();
            dashboardForm.UpdateTotalAuthorCountLabel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int authorID = Convert.ToInt32(textBox1.Text);
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            classAuthor.EditAuthor(authorID, firstName, lastName);
            dataGridView_authors.DataSource = classAuthor.GetAuthors();
            dashboardForm.UpdateTotalAuthorCountLabel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int authorID = Convert.ToInt32(textBox1.Text);
            classAuthor.DeleteAuthor(authorID);
            dataGridView_authors.DataSource = classAuthor.GetAuthors();
            dashboardForm.UpdateTotalAuthorCountLabel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int authorID))
            {
                DataTable bookTitles = classBook.GetBookTitlesByAuthorID(authorID);

                dataGridView_authors.Columns[0].DataPropertyName = "BookTitle";
                dataGridView_authors.DataSource = bookTitles;
            }
            else
            {
                MessageBox.Show("Please enter a valid author ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
