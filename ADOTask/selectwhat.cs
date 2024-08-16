using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOTask
{
    public partial class selectwhat : Form
    {
        public selectwhat()
        {
            InitializeComponent();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            new Book().Show();
        }

        private void buttonMember_Click(object sender, EventArgs e)
        {
            new Member().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Borroing().Show();
        }
    }
}
