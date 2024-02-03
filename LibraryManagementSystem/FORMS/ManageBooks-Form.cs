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
    public partial class ManageBooks_Form : Form
    {
        private ClassBook classBook = new ClassBook();
        private Dashboard_Form dashboardForm;

        public ManageBooks_Form()
        {
            InitializeComponent();
            dataGridView_books.DataSource = classBook.GetBooks();
            dashboardForm = new Dashboard_Form();
        }

        private bool IsInteger(string value)
        {
            int result;
            return int.TryParse(value, out result);
        }

        private bool IsFloat(string value)
        {
            float result;
            return float.TryParse(value, out result);
        }

        private byte[] ImageToByteArray(Image image)
        {
            // This code checks if the image is null
            if (image == null)
            {
                MessageBox.Show("Please select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // This code converts the image to byte array
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string isbn = textBox_isbn.Text;
            string title = textBox_title.Text;

            if (!IsInteger(textBox_author.Text))
            {
                MessageBox.Show("Author ID must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int authorID = Convert.ToInt32(textBox_author.Text);

            if (!IsInteger(textBox_genre.Text))
            {
                MessageBox.Show("Genre ID must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int genreID = Convert.ToInt32(textBox_genre.Text);

            if (!IsFloat(textBox_price.Text))
            {
                MessageBox.Show("Book price must be a valid float value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float price = float.Parse(textBox_price.Text);

            string publisher = textBox_publisher.Text;
            DateTime dateReceived = dateTimePicker1.Value;
            string description = textBox_description.Text;

            Image cover = pictureBox_cover.Image;
            byte[] coverBytes = ImageToByteArray(cover);

            // This code checks if coverBytes is null, for example if image is not selected
            if (coverBytes == null)
            {
                return;
            }

            classBook.AddBook(isbn, title, authorID, genreID, price, publisher, dateReceived, description, coverBytes);
            dataGridView_books.DataSource = classBook.GetBooks();
            dashboardForm.UpdateTotalBookCountLabel();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(textBox_id.Text);
            string isbn = textBox_isbn.Text;
            string title = textBox_title.Text;

            if (!IsInteger(textBox_author.Text))
            {
                MessageBox.Show("Author ID must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int authorID = Convert.ToInt32(textBox_author.Text);

            if (!IsInteger(textBox_genre.Text))
            {
                MessageBox.Show("Genre ID must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int genreID = Convert.ToInt32(textBox_genre.Text);

            if (!IsFloat(textBox_price.Text))
            {
                MessageBox.Show("Book price must be a valid float value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float price = float.Parse(textBox_price.Text);

            string publisher = textBox_publisher.Text;
            DateTime dateReceived = dateTimePicker1.Value;
            string description = textBox_description.Text;

            Image cover = pictureBox_cover.Image;
            byte[] coverBytes = ImageToByteArray(cover);

            // This code checks if coverBytes is null, for example if image is not selected
            if (coverBytes == null)
            {
                return;
            }

            classBook.EditBook(bookID, isbn, title, authorID, genreID, price, publisher, dateReceived, description, coverBytes);
            dataGridView_books.DataSource = classBook.GetBooks();
            dashboardForm.UpdateTotalBookCountLabel();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(textBox_id.Text);
            classBook.DeleteBook(bookID);
            dataGridView_books.DataSource = classBook.GetBooks();
            dashboardForm.UpdateTotalBookCountLabel();
        }

        private void button_cover_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.jpg;*.png;*.gif) | *.jpg;*.jpeg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                string fileName = opf.FileName;

                byte[] cover = File.ReadAllBytes(fileName);

                pictureBox_cover.Image = Image.FromStream(new MemoryStream(cover));
            }
        }

        private void button_txt_Click(object sender, EventArgs e)
        {
            try
            {
                // Gets data from Table
                DataTable booksTable = classBook.GetBooks();

                // Sets the desktop path
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "books_export.txt");

                // Writes data to text file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Does not takes "book_cover"
                    foreach (DataColumn column in booksTable.Columns)
                    {
                        if (column.ColumnName != "book_cover")
                        {
                            writer.Write(column.ColumnName + "\t");
                        }
                    }
                    writer.WriteLine();

                    // Writes rows of data without "book_cover"
                    foreach (DataRow row in booksTable.Rows)
                    {
                        foreach (DataColumn column in booksTable.Columns)
                        {
                            if (column.ColumnName != "book_cover")
                            {
                                writer.Write(row[column] + "\t");
                            }
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
