namespace ADOTask
{
    partial class Book
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
            dataGridView1 = new DataGridView();
            button_EditBook = new Button();
            menuStrip1 = new MenuStrip();
            newToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            label7 = new Label();
            textBox_Title = new TextBox();
            button_DeleteBook = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox_AvailableCopies = new TextBox();
            textBox_TotalCopies = new TextBox();
            textBox_PublicationYear = new TextBox();
            textBox_ISBN = new TextBox();
            textBox_Author = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(447, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1079, 587);
            dataGridView1.TabIndex = 0;
            // 
            // button_EditBook
            // 
            button_EditBook.Location = new Point(205, 430);
            button_EditBook.Name = "button_EditBook";
            button_EditBook.Size = new Size(94, 29);
            button_EditBook.TabIndex = 1;
            button_EditBook.Text = "Edit Book";
            button_EditBook.UseVisualStyleBackColor = true;
            button_EditBook.Click += button_addBook_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, searchToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1520, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(50, 24);
            newToolStripMenuItem.Text = "new";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(65, 24);
            searchToolStripMenuItem.Text = "search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 73);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 27;
            label7.Text = "Title";
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(0, 96);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(425, 27);
            textBox_Title.TabIndex = 26;
            // 
            // button_DeleteBook
            // 
            button_DeleteBook.Location = new Point(331, 430);
            button_DeleteBook.Name = "button_DeleteBook";
            button_DeleteBook.Size = new Size(94, 29);
            button_DeleteBook.TabIndex = 25;
            button_DeleteBook.Text = "Delete";
            button_DeleteBook.UseVisualStyleBackColor = true;
            button_DeleteBook.Click += button_DeleteBook_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 351);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 24;
            label5.Text = "AvailableCopies";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 284);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 23;
            label4.Text = "TotalCopies";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 231);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 22;
            label3.Text = "PublicationYear";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 178);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 21;
            label2.Text = "ISBN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 125);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 20;
            label1.Text = "Author";
            // 
            // textBox_AvailableCopies
            // 
            textBox_AvailableCopies.Location = new Point(5, 374);
            textBox_AvailableCopies.Name = "textBox_AvailableCopies";
            textBox_AvailableCopies.Size = new Size(420, 27);
            textBox_AvailableCopies.TabIndex = 19;
            // 
            // textBox_TotalCopies
            // 
            textBox_TotalCopies.Location = new Point(5, 307);
            textBox_TotalCopies.Name = "textBox_TotalCopies";
            textBox_TotalCopies.Size = new Size(420, 27);
            textBox_TotalCopies.TabIndex = 18;
            // 
            // textBox_PublicationYear
            // 
            textBox_PublicationYear.Location = new Point(0, 254);
            textBox_PublicationYear.Name = "textBox_PublicationYear";
            textBox_PublicationYear.Size = new Size(425, 27);
            textBox_PublicationYear.TabIndex = 17;
            // 
            // textBox_ISBN
            // 
            textBox_ISBN.Location = new Point(0, 201);
            textBox_ISBN.Name = "textBox_ISBN";
            textBox_ISBN.Size = new Size(425, 27);
            textBox_ISBN.TabIndex = 16;
            // 
            // textBox_Author
            // 
            textBox_Author.Location = new Point(0, 148);
            textBox_Author.Name = "textBox_Author";
            textBox_Author.Size = new Size(425, 27);
            textBox_Author.TabIndex = 15;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 769);
            Controls.Add(label7);
            Controls.Add(textBox_Title);
            Controls.Add(button_DeleteBook);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_AvailableCopies);
            Controls.Add(textBox_TotalCopies);
            Controls.Add(textBox_PublicationYear);
            Controls.Add(textBox_ISBN);
            Controls.Add(textBox_Author);
            Controls.Add(button_EditBook);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Book";
            Text = "Books";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_EditBook;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private Label label7;
        private TextBox textBox_Title;
        private Button button_DeleteBook;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox_AvailableCopies;
        private TextBox textBox_TotalCopies;
        private TextBox textBox_PublicationYear;
        private TextBox textBox_ISBN;
        private TextBox textBox_Author;
    }
}