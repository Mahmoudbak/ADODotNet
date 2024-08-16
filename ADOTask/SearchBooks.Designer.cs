namespace ADOTask
{
    partial class SearchBooks
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Title = new Label();
            ISBN = new Label();
            Author = new Label();
            button_search = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(34, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 27);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(34, 39);
            Title.Name = "Title";
            Title.Size = new Size(38, 20);
            Title.TabIndex = 3;
            Title.Text = "Title";
            // 
            // ISBN
            // 
            ISBN.AutoSize = true;
            ISBN.Location = new Point(34, 94);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(54, 20);
            ISBN.TabIndex = 4;
            ISBN.Text = "Author";
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Location = new Point(34, 147);
            Author.Name = "Author";
            Author.Size = new Size(41, 20);
            Author.TabIndex = 5;
            Author.Text = "ISBN";
            // 
            // button_search
            // 
            button_search.Location = new Point(184, 203);
            button_search.Name = "button_search";
            button_search.Size = new Size(94, 29);
            button_search.TabIndex = 6;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1181, 518);
            dataGridView1.TabIndex = 7;
            // 
            // SearchBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 728);
            Controls.Add(dataGridView1);
            Controls.Add(button_search);
            Controls.Add(Author);
            Controls.Add(ISBN);
            Controls.Add(Title);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "SearchBooks";
            Text = "SearchBooks";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label Title;
        private Label ISBN;
        private Label Author;
        private Button button_search;
        private DataGridView dataGridView1;
    }
}