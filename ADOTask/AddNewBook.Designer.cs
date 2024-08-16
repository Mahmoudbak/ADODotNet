namespace ADOTask
{
    partial class AddNewBook
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
            textBox_Author = new TextBox();
            textBox_ISBN = new TextBox();
            textBox_PublicationYear = new TextBox();
            textBox_TotalCopies = new TextBox();
            textBox_AvailableCopies = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button_EnterAddNewBook = new Button();
            label6 = new Label();
            textBox_Title = new TextBox();
            label7 = new Label();
            button_searshBooks = new Button();
            SuspendLayout();
            // 
            // textBox_Author
            // 
            textBox_Author.Location = new Point(6, 102);
            textBox_Author.Name = "textBox_Author";
            textBox_Author.Size = new Size(441, 27);
            textBox_Author.TabIndex = 0;
            // 
            // textBox_ISBN
            // 
            textBox_ISBN.Location = new Point(6, 155);
            textBox_ISBN.Name = "textBox_ISBN";
            textBox_ISBN.Size = new Size(441, 27);
            textBox_ISBN.TabIndex = 1;
            // 
            // textBox_PublicationYear
            // 
            textBox_PublicationYear.Location = new Point(6, 208);
            textBox_PublicationYear.Name = "textBox_PublicationYear";
            textBox_PublicationYear.Size = new Size(441, 27);
            textBox_PublicationYear.TabIndex = 2;
            // 
            // textBox_TotalCopies
            // 
            textBox_TotalCopies.Location = new Point(11, 261);
            textBox_TotalCopies.Name = "textBox_TotalCopies";
            textBox_TotalCopies.Size = new Size(441, 27);
            textBox_TotalCopies.TabIndex = 3;
            // 
            // textBox_AvailableCopies
            // 
            textBox_AvailableCopies.Location = new Point(11, 328);
            textBox_AvailableCopies.Name = "textBox_AvailableCopies";
            textBox_AvailableCopies.Size = new Size(446, 27);
            textBox_AvailableCopies.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 6;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 132);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 7;
            label2.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 185);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 8;
            label3.Text = "PublicationYear";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 238);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 9;
            label4.Text = "TotalCopies";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 305);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 10;
            label5.Text = "AvailableCopies";
            // 
            // button_EnterAddNewBook
            // 
            button_EnterAddNewBook.Location = new Point(363, 375);
            button_EnterAddNewBook.Name = "button_EnterAddNewBook";
            button_EnterAddNewBook.Size = new Size(94, 29);
            button_EnterAddNewBook.TabIndex = 11;
            button_EnterAddNewBook.Text = "Enter";
            button_EnterAddNewBook.UseVisualStyleBackColor = true;
            button_EnterAddNewBook.Click += button_EnterAddNewBook_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, -20);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 13;
            label6.Text = "Author";
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(6, 49);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(441, 27);
            textBox_Title.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 27);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 14;
            label7.Text = "Title";
            // 
            // button_searshBooks
            // 
            button_searshBooks.Location = new Point(263, 375);
            button_searshBooks.Name = "button_searshBooks";
            button_searshBooks.Size = new Size(94, 29);
            button_searshBooks.TabIndex = 15;
            button_searshBooks.Text = "search";
            button_searshBooks.UseVisualStyleBackColor = true;
            button_searshBooks.Click += button_searshBooks_Click;
            // 
            // AddNewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 450);
            Controls.Add(button_searshBooks);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox_Title);
            Controls.Add(button_EnterAddNewBook);
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
            Name = "AddNewBook";
            Text = "AddNewBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Author;
        private TextBox textBox_ISBN;
        private TextBox textBox_PublicationYear;
        private TextBox textBox_TotalCopies;
        private TextBox textBox_AvailableCopies;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_EnterAddNewBook;
        private Label label6;
        private TextBox textBox_Title;
        private Label label7;
        private Button button_searshBooks;
    }
}