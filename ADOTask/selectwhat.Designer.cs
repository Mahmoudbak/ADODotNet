namespace ADOTask
{
    partial class selectwhat
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
            buttonBooks = new Button();
            buttonMember = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonBooks
            // 
            buttonBooks.Location = new Point(16, 46);
            buttonBooks.Name = "buttonBooks";
            buttonBooks.Size = new Size(209, 29);
            buttonBooks.TabIndex = 0;
            buttonBooks.Text = "button_Books";
            buttonBooks.UseVisualStyleBackColor = true;
            buttonBooks.Click += buttonBooks_Click;
            // 
            // buttonMember
            // 
            buttonMember.Location = new Point(16, 112);
            buttonMember.Name = "buttonMember";
            buttonMember.Size = new Size(209, 29);
            buttonMember.TabIndex = 1;
            buttonMember.Text = "button_Member";
            buttonMember.UseVisualStyleBackColor = true;
            buttonMember.Click += buttonMember_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 2;
            label1.Text = "BooksMangeMent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 89);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 3;
            label2.Text = "MemberMangment";
            // 
            // button1
            // 
            button1.Location = new Point(16, 170);
            button1.Name = "button1";
            button1.Size = new Size(209, 29);
            button1.TabIndex = 4;
            button1.Text = "button_Borroing_Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 147);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 5;
            label3.Text = "Borrowings ";
            // 
            // selectwhat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 216);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonMember);
            Controls.Add(buttonBooks);
            Name = "selectwhat";
            Text = "selectwhat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBooks;
        private Button buttonMember;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}