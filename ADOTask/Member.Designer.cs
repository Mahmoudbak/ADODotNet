namespace ADOTask
{
    partial class Member
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
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label_FristName = new Label();
            textBox_Phone = new TextBox();
            textBox_Email = new TextBox();
            textBox_lastName = new TextBox();
            textBox_FristName = new TextBox();
            button_DeleteMember = new Button();
            button_EditeMember = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(402, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(797, 587);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1229, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(51, 24);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 263);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 15;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 182);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 14;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 112);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 13;
            label2.Text = "LastName";
            // 
            // label_FristName
            // 
            label_FristName.AutoSize = true;
            label_FristName.Location = new Point(0, 38);
            label_FristName.Name = "label_FristName";
            label_FristName.Size = new Size(76, 20);
            label_FristName.TabIndex = 12;
            label_FristName.Text = "FristName";
            // 
            // textBox_Phone
            // 
            textBox_Phone.Location = new Point(0, 286);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(387, 27);
            textBox_Phone.TabIndex = 11;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(0, 205);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(387, 27);
            textBox_Email.TabIndex = 10;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Location = new Point(0, 135);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(387, 27);
            textBox_lastName.TabIndex = 9;
            // 
            // textBox_FristName
            // 
            textBox_FristName.Location = new Point(0, 61);
            textBox_FristName.Name = "textBox_FristName";
            textBox_FristName.Size = new Size(387, 27);
            textBox_FristName.TabIndex = 8;
            // 
            // button_DeleteMember
            // 
            button_DeleteMember.Location = new Point(293, 319);
            button_DeleteMember.Name = "button_DeleteMember";
            button_DeleteMember.Size = new Size(94, 29);
            button_DeleteMember.TabIndex = 16;
            button_DeleteMember.Text = "Delete";
            button_DeleteMember.UseVisualStyleBackColor = true;
            button_DeleteMember.Click += button_DeleteMember_Click;
            // 
            // button_EditeMember
            // 
            button_EditeMember.Location = new Point(164, 319);
            button_EditeMember.Name = "button_EditeMember";
            button_EditeMember.Size = new Size(94, 29);
            button_EditeMember.TabIndex = 17;
            button_EditeMember.Text = "Edit";
            button_EditeMember.UseVisualStyleBackColor = true;
            button_EditeMember.Click += button_EditeMember_Click;
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 612);
            Controls.Add(button_EditeMember);
            Controls.Add(button_DeleteMember);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label_FristName);
            Controls.Add(textBox_Phone);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_lastName);
            Controls.Add(textBox_FristName);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Member";
            Text = "Member";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label_FristName;
        private TextBox textBox_Phone;
        private TextBox textBox_Email;
        private TextBox textBox_lastName;
        private TextBox textBox_FristName;
        private Button button_DeleteMember;
        private Button button_EditeMember;
    }
}