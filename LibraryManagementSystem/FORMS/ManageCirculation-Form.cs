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
    public partial class ManageCirculation_Form : Form
    {
        private ClassCirculation classCirculation = new ClassCirculation();

        public ManageCirculation_Form()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_searchbook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int bookID))
            {
                MessageBox.Show("Please enter a valid book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (classCirculation.IsBookAvailable(bookID))
            {
                MessageBox.Show("This book is available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This book is not available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_searchmember_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int memberID))
            {
                MessageBox.Show("Please enter a valid member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> issuedBooks = classCirculation.GetIssuedBooksByMember(memberID);

            MessageBox.Show($"Books issued by the member:\n{string.Join("\n", issuedBooks)}", "Issued Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_issue_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int bookID) || !int.TryParse(textBox2.Text, out int memberID))
            {
                MessageBox.Show("Please enter valid book and member IDs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (classCirculation.IsBookIssued(bookID))
            {
                MessageBox.Show("This book is already issued.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            classCirculation.IssueBook(bookID, memberID);

            MessageBox.Show("Book issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int bookID) || !int.TryParse(textBox2.Text, out int memberID))
            {
                MessageBox.Show("Please enter valid book and member IDs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!classCirculation.IsBookIssued(bookID))
            {
                MessageBox.Show("This book is not currently issued.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            classCirculation.ReturnBook(bookID, memberID);

            MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
