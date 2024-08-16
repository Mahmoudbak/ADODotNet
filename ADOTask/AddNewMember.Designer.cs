namespace ADOTask
{
    partial class AddNewMember
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
            components = new System.ComponentModel.Container();
            textBox_FristName = new TextBox();
            textBox_lastName = new TextBox();
            textBox_Email = new TextBox();
            textBox_Phone = new TextBox();
            label_FristName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_EnterMember = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // textBox_FristName
            // 
            textBox_FristName.Location = new Point(23, 50);
            textBox_FristName.Name = "textBox_FristName";
            textBox_FristName.Size = new Size(387, 27);
            textBox_FristName.TabIndex = 0;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Location = new Point(23, 124);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(387, 27);
            textBox_lastName.TabIndex = 1;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(23, 194);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(387, 27);
            textBox_Email.TabIndex = 2;
            // 
            // textBox_Phone
            // 
            textBox_Phone.Location = new Point(23, 275);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(387, 27);
            textBox_Phone.TabIndex = 3;
            // 
            // label_FristName
            // 
            label_FristName.AutoSize = true;
            label_FristName.Location = new Point(23, 27);
            label_FristName.Name = "label_FristName";
            label_FristName.Size = new Size(76, 20);
            label_FristName.TabIndex = 4;
            label_FristName.Text = "FristName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 101);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 171);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 252);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // button_EnterMember
            // 
            button_EnterMember.Location = new Point(316, 308);
            button_EnterMember.Name = "button_EnterMember";
            button_EnterMember.Size = new Size(94, 29);
            button_EnterMember.TabIndex = 8;
            button_EnterMember.Text = "Enter";
            button_EnterMember.UseVisualStyleBackColor = true;
            button_EnterMember.Click += button_EnterMember_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AddNewMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_EnterMember);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label_FristName);
            Controls.Add(textBox_Phone);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_lastName);
            Controls.Add(textBox_FristName);
            Name = "AddNewMember";
            Text = "AddNewMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_FristName;
        private TextBox textBox_lastName;
        private TextBox textBox_Email;
        private TextBox textBox_Phone;
        private Label label_FristName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_EnterMember;
        private ContextMenuStrip contextMenuStrip1;
    }
}