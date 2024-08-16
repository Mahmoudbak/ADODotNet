namespace ADOTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label_password = new Label();
            label3 = new Label();
            textBox_UserName = new TextBox();
            textBox_password = new TextBox();
            button_newUser = new Button();
            button_enter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 142);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(215, 198);
            label_password.Name = "label_password";
            label_password.Size = new Size(70, 20);
            label_password.TabIndex = 1;
            label_password.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F);
            label3.Location = new Point(38, 28);
            label3.Name = "label3";
            label3.Size = new Size(636, 67);
            label3.TabIndex = 2;
            label3.Text = "Welcome Mahmoud Library";
            //label3.Click += label3_Click;
            // 
            // textBox_UserName
            // 
            textBox_UserName.Location = new Point(215, 165);
            textBox_UserName.Name = "textBox_UserName";
            textBox_UserName.Size = new Size(261, 27);
            textBox_UserName.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(215, 221);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(261, 27);
            textBox_password.TabIndex = 4;
            // 
            // button_newUser
            // 
            button_newUser.Location = new Point(215, 264);
            button_newUser.Name = "button_newUser";
            button_newUser.Size = new Size(94, 29);
            button_newUser.TabIndex = 5;
            button_newUser.Text = "New";
            button_newUser.UseVisualStyleBackColor = true;
            button_newUser.Click += button_newUser_Click;
            // 
            // button_enter
            // 
            button_enter.Location = new Point(369, 264);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(94, 29);
            button_enter.TabIndex = 6;
            button_enter.Text = "Enter";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 450);
            Controls.Add(button_enter);
            Controls.Add(button_newUser);
            Controls.Add(textBox_password);
            Controls.Add(textBox_UserName);
            Controls.Add(label3);
            Controls.Add(label_password);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_password;
        private Label label3;
        private TextBox textBox_UserName;
        private TextBox textBox_password;
        private Button button_newUser;
        private Button button_enter;
    }
}
