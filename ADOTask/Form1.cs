using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace ADOTask
{

    public partial class Form1 : Form
    {
        static string connectionString = "Server=.\\;Database=AdoDotNet;Trusted_Connection;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            new selectwhat().Show();


        }

        private void button_newUser_Click(object sender, EventArgs e)
        {
            new enteruser().ShowDialog();
        }
      
    }
}
