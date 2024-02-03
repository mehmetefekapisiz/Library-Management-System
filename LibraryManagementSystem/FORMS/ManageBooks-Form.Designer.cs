namespace LibraryManagementSystem.FORMS
{
    partial class ManageBooks_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_txt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.button_cover = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox_cover = new System.Windows.Forms.PictureBox();
            this.label_cover = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_datereceived = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_publisher = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.dataGridView_books = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_isbn = new System.Windows.Forms.TextBox();
            this.label_isbn = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Vamp_LCD_TR", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 100);
            this.label1.TabIndex = 5;
            this.label1.Text = "Books";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.button_txt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_author);
            this.panel1.Controls.Add(this.textBox_genre);
            this.panel1.Controls.Add(this.textBox_publisher);
            this.panel1.Controls.Add(this.button_cover);
            this.panel1.Controls.Add(this.textBox_price);
            this.panel1.Controls.Add(this.textBox_description);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.pictureBox_cover);
            this.panel1.Controls.Add(this.label_cover);
            this.panel1.Controls.Add(this.label_description);
            this.panel1.Controls.Add(this.label_datereceived);
            this.panel1.Controls.Add(this.label_price);
            this.panel1.Controls.Add(this.label_publisher);
            this.panel1.Controls.Add(this.label_genre);
            this.panel1.Controls.Add(this.label_author);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Controls.Add(this.textBox_title);
            this.panel1.Controls.Add(this.dataGridView_books);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.textBox_isbn);
            this.panel1.Controls.Add(this.label_isbn);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 400);
            this.panel1.TabIndex = 6;
            // 
            // button_txt
            // 
            this.button_txt.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.button_txt.Location = new System.Drawing.Point(345, 365);
            this.button_txt.Name = "button_txt";
            this.button_txt.Size = new System.Drawing.Size(160, 23);
            this.button_txt.TabIndex = 34;
            this.button_txt.Text = "Export to .txt";
            this.button_txt.UseVisualStyleBackColor = true;
            this.button_txt.Click += new System.EventHandler(this.button_txt_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(461, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 11);
            this.label7.TabIndex = 33;
            this.label7.Text = "*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(331, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 11);
            this.label6.TabIndex = 32;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(331, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 11);
            this.label5.TabIndex = 31;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(331, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 11);
            this.label4.TabIndex = 30;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(331, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 11);
            this.label3.TabIndex = 29;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(331, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 11);
            this.label2.TabIndex = 28;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_author
            // 
            this.textBox_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_author.Location = new System.Drawing.Point(175, 110);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(170, 20);
            this.textBox_author.TabIndex = 27;
            // 
            // textBox_genre
            // 
            this.textBox_genre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_genre.Location = new System.Drawing.Point(175, 140);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(170, 20);
            this.textBox_genre.TabIndex = 26;
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_publisher.Location = new System.Drawing.Point(175, 200);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(170, 20);
            this.textBox_publisher.TabIndex = 25;
            // 
            // button_cover
            // 
            this.button_cover.BackColor = System.Drawing.Color.Gray;
            this.button_cover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cover.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.button_cover.ForeColor = System.Drawing.SystemColors.Window;
            this.button_cover.Location = new System.Drawing.Point(375, 205);
            this.button_cover.Name = "button_cover";
            this.button_cover.Size = new System.Drawing.Size(100, 28);
            this.button_cover.TabIndex = 22;
            this.button_cover.Text = "Select Cover";
            this.button_cover.UseVisualStyleBackColor = false;
            this.button_cover.Click += new System.EventHandler(this.button_cover_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_price.Location = new System.Drawing.Point(175, 170);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(170, 20);
            this.textBox_price.TabIndex = 20;
            // 
            // textBox_description
            // 
            this.textBox_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_description.Location = new System.Drawing.Point(175, 260);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(170, 80);
            this.textBox_description.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 230);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 21, 0, 0, 0, 0);
            // 
            // pictureBox_cover
            // 
            this.pictureBox_cover.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_cover.Location = new System.Drawing.Point(375, 50);
            this.pictureBox_cover.Name = "pictureBox_cover";
            this.pictureBox_cover.Size = new System.Drawing.Size(100, 150);
            this.pictureBox_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_cover.TabIndex = 17;
            this.pictureBox_cover.TabStop = false;
            // 
            // label_cover
            // 
            this.label_cover.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_cover.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_cover.ForeColor = System.Drawing.SystemColors.Window;
            this.label_cover.Location = new System.Drawing.Point(350, 20);
            this.label_cover.Name = "label_cover";
            this.label_cover.Size = new System.Drawing.Size(155, 20);
            this.label_cover.TabIndex = 16;
            this.label_cover.Text = "Cover:";
            this.label_cover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_description
            // 
            this.label_description.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_description.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_description.ForeColor = System.Drawing.SystemColors.Window;
            this.label_description.Location = new System.Drawing.Point(15, 260);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(155, 24);
            this.label_description.TabIndex = 15;
            this.label_description.Text = "Description:";
            this.label_description.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_datereceived
            // 
            this.label_datereceived.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_datereceived.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_datereceived.ForeColor = System.Drawing.SystemColors.Window;
            this.label_datereceived.Location = new System.Drawing.Point(15, 230);
            this.label_datereceived.Name = "label_datereceived";
            this.label_datereceived.Size = new System.Drawing.Size(155, 20);
            this.label_datereceived.TabIndex = 14;
            this.label_datereceived.Text = "Date Received:";
            this.label_datereceived.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_price
            // 
            this.label_price.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_price.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_price.ForeColor = System.Drawing.SystemColors.Window;
            this.label_price.Location = new System.Drawing.Point(15, 170);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(155, 20);
            this.label_price.TabIndex = 13;
            this.label_price.Text = "Price:";
            this.label_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_publisher
            // 
            this.label_publisher.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_publisher.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_publisher.ForeColor = System.Drawing.SystemColors.Window;
            this.label_publisher.Location = new System.Drawing.Point(15, 200);
            this.label_publisher.Name = "label_publisher";
            this.label_publisher.Size = new System.Drawing.Size(155, 20);
            this.label_publisher.TabIndex = 12;
            this.label_publisher.Text = "Publisher:";
            this.label_publisher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_genre
            // 
            this.label_genre.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_genre.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_genre.ForeColor = System.Drawing.SystemColors.Window;
            this.label_genre.Location = new System.Drawing.Point(15, 140);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(155, 20);
            this.label_genre.TabIndex = 11;
            this.label_genre.Text = "Genre ID:";
            this.label_genre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_author
            // 
            this.label_author.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_author.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_author.ForeColor = System.Drawing.SystemColors.Window;
            this.label_author.Location = new System.Drawing.Point(15, 110);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(155, 20);
            this.label_author.TabIndex = 10;
            this.label_author.Text = "Author ID:";
            this.label_author.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_title
            // 
            this.label_title.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_title.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_title.ForeColor = System.Drawing.SystemColors.Window;
            this.label_title.Location = new System.Drawing.Point(15, 80);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(155, 20);
            this.label_title.TabIndex = 9;
            this.label_title.Text = "Title:";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_title
            // 
            this.textBox_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_title.Location = new System.Drawing.Point(175, 80);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(170, 20);
            this.textBox_title.TabIndex = 8;
            // 
            // dataGridView_books
            // 
            this.dataGridView_books.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_books.Location = new System.Drawing.Point(505, 20);
            this.dataGridView_books.Name = "dataGridView_books";
            this.dataGridView_books.Size = new System.Drawing.Size(480, 320);
            this.dataGridView_books.TabIndex = 7;
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.button_delete.Location = new System.Drawing.Point(245, 365);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.button_edit.Location = new System.Drawing.Point(135, 365);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 5;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_add.Location = new System.Drawing.Point(25, 365);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_isbn
            // 
            this.textBox_isbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_isbn.Location = new System.Drawing.Point(175, 50);
            this.textBox_isbn.Name = "textBox_isbn";
            this.textBox_isbn.Size = new System.Drawing.Size(170, 20);
            this.textBox_isbn.TabIndex = 3;
            // 
            // label_isbn
            // 
            this.label_isbn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_isbn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_isbn.ForeColor = System.Drawing.SystemColors.Window;
            this.label_isbn.Location = new System.Drawing.Point(15, 50);
            this.label_isbn.Name = "label_isbn";
            this.label_isbn.Size = new System.Drawing.Size(155, 20);
            this.label_isbn.TabIndex = 2;
            this.label_isbn.Text = "ISBN:";
            this.label_isbn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_id
            // 
            this.label_id.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label_id.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_id.ForeColor = System.Drawing.SystemColors.Window;
            this.label_id.Location = new System.Drawing.Point(15, 20);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(155, 20);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID:";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_id
            // 
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Location = new System.Drawing.Point(175, 20);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(170, 20);
            this.textBox_id.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Indigo;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_close.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_close.ForeColor = System.Drawing.SystemColors.Window;
            this.button_close.Location = new System.Drawing.Point(960, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(40, 40);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Indigo;
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.book_giff;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ManageBooks_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageBooks_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBooks_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.DataGridView dataGridView_books;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_isbn;
        private System.Windows.Forms.Label label_isbn;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_publisher;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_datereceived;
        private System.Windows.Forms.Label label_cover;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.PictureBox pictureBox_cover;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Button button_cover;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.TextBox textBox_genre;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_txt;
    }
}