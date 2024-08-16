namespace ADOTask
{
    partial class enteruser
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
            button_enter = new Button();
            textBox_password = new TextBox();
            textBox_UserName = new TextBox();
            label_password = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_enter
            // 
            button_enter.Location = new Point(223, 163);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(94, 29);
            button_enter.TabIndex = 12;
            button_enter.Text = "Enter";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += button_enter_Click;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(69, 120);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(261, 27);
            textBox_password.TabIndex = 10;
            // 
            // textBox_UserName
            // 
            textBox_UserName.Location = new Point(69, 64);
            textBox_UserName.Name = "textBox_UserName";
            textBox_UserName.Size = new Size(261, 27);
            textBox_UserName.TabIndex = 9;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(69, 97);
            label_password.Name = "label_password";
            label_password.Size = new Size(70, 20);
            label_password.TabIndex = 8;
            label_password.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 41);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 7;
            label1.Text = "User Name";
            // 
            // enteruser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 235);
            Controls.Add(button_enter);
            Controls.Add(textBox_password);
            Controls.Add(textBox_UserName);
            Controls.Add(label_password);
            Controls.Add(label1);
            Name = "enteruser";
            Text = "enteruser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_enter;
        private TextBox textBox_password;
        private TextBox textBox_UserName;
        private Label label_password;
        private Label label1;
    }
}