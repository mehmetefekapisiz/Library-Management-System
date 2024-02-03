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
    public partial class ManageGenres_Form : Form
    {
        private ClassGenre classGenre = new ClassGenre();

        public ManageGenres_Form()
        {
            InitializeComponent();
            dataGridView_genres.DataSource = classGenre.GetGenres();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            classGenre.AddGenre(name);
            dataGridView_genres.DataSource = classGenre.GetGenres();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int genreID = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            classGenre.EditGenre(genreID, name);
            dataGridView_genres.DataSource = classGenre.GetGenres();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int genreID = Convert.ToInt32(textBox1.Text);
            classGenre.DeleteGenre(genreID);
            dataGridView_genres.DataSource = classGenre.GetGenres();
        }
    }
}
