using System;
using System.Windows.Forms;
using LibraryManagementSystem.CLASSES;

namespace LibraryManagementSystem.FORMS
{
    public partial class Dashboard_Form : Form
    {
        private ManageGenres_Form manageGenresForm;
        private ManageBooks_Form manageBooksForm;
        private ManageAuthors_Form manageAuthorsForm;
        private ManageMembers_Form manageMembersForm;
        private ManageCirculation_Form manageCirculationForm;
        private ManageUsers_Form manageUsersForm;
        private ClassBook classBook;
        private ClassAuthor classAuthor;
        private ClassMember classMember;

        public Dashboard_Form()
        {
            InitializeComponent();

            classBook = new ClassBook();
            UpdateTotalBookCountLabel();

            classAuthor = new ClassAuthor();
            UpdateTotalAuthorCountLabel();

            classMember = new ClassMember();
            UpdateTotalMemberCountLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (manageBooksForm != null && !manageBooksForm.IsDisposed)
            {
                manageBooksForm.Close();
                manageBooksForm = null;
            }
            else
            {
                manageBooksForm = new ManageBooks_Form();
                manageBooksForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (manageAuthorsForm != null && !manageAuthorsForm.IsDisposed)
            {
                manageAuthorsForm.Close();
                manageAuthorsForm = null;
            }
            else
            {
                manageAuthorsForm = new ManageAuthors_Form();
                manageAuthorsForm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (manageMembersForm != null && !manageMembersForm.IsDisposed)
            {
                manageMembersForm.Close();
                manageMembersForm = null;
            }
            else
            {
                manageMembersForm = new ManageMembers_Form();
                manageMembersForm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (manageGenresForm != null && !manageGenresForm.IsDisposed)
            {
                manageGenresForm.Close();
                manageGenresForm = null;
            }
            else
            {
                manageGenresForm = new ManageGenres_Form();
                manageGenresForm.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (manageUsersForm != null && !manageUsersForm.IsDisposed)
            {
                manageUsersForm.Close();
                manageUsersForm = null;
            }
            else
            {
                manageUsersForm = new ManageUsers_Form();
                manageUsersForm.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (manageCirculationForm != null && !manageCirculationForm.IsDisposed)
            {
                manageCirculationForm.Close();
                manageCirculationForm = null;
            }
            else
            {
                manageCirculationForm = new ManageCirculation_Form();
                manageCirculationForm.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void UpdateTotalBookCountLabel()
        {
            int totalBookCount = classBook.GetTotalBookCount();
            label6.Text = totalBookCount.ToString(); // The number only updates when the application is closed and opened.
        }

        public void UpdateTotalAuthorCountLabel()
        {
            int totalAuthorCount = classAuthor.GetTotalAuthorCount();
            label7.Text = totalAuthorCount.ToString(); // The number only updates when the application is closed and opened.
        }
        public void UpdateTotalMemberCountLabel()
        {
            int totalMemberCount = classMember.GetTotalMemberCount();
            label8.Text = totalMemberCount.ToString(); // The number only updates when the application is closed and opened.
        }
    }
}
