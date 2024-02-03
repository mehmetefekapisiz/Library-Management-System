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
    public partial class ManageMembers_Form : Form
    {
        private ClassMember classMember = new ClassMember();
        private Dashboard_Form dashboardForm;

        public ManageMembers_Form()
        {
            InitializeComponent();
            dataGridView_members.DataSource = classMember.GetMembers();
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
            string gender = textBox4.Text;
            string phone = textBox5.Text;
            string email = textBox6.Text;
            classMember.AddMember(firstName, lastName, gender, phone, email);
            dataGridView_members.DataSource = classMember.GetMembers();
            dashboardForm.UpdateTotalMemberCountLabel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int memberID = Convert.ToInt32(textBox1.Text);
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string gender = textBox4.Text;
            string phone = textBox5.Text;
            string email = textBox6.Text;
            classMember.EditMember(memberID, firstName, lastName, gender, phone, email);
            dataGridView_members.DataSource = classMember.GetMembers();
            dashboardForm.UpdateTotalMemberCountLabel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int memberID = Convert.ToInt32(textBox1.Text);
            classMember.DeleteMember(memberID);
            dataGridView_members.DataSource = classMember.GetMembers();
            dashboardForm.UpdateTotalMemberCountLabel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Gets data from Table
                DataTable membersTable = classMember.GetMembers();

                // Sets the desktop path
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "members_export.txt");

                // Writes data to text file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Writes columns of data
                    foreach (DataColumn column in membersTable.Columns)
                    {
                        writer.Write(column.ColumnName + "\t");
                    }
                    writer.WriteLine();

                    // Writes rows of data
                    foreach (DataRow row in membersTable.Rows)
                    {
                        foreach (DataColumn column in membersTable.Columns)
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
