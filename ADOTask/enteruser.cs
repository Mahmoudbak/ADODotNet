using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOTask
{
    public partial class enteruser : Form
    {
        public enteruser()
        {
            InitializeComponent();
        }
        private void InsertUser(string username, string password)
        {
            string connectionString = "Server=.\\;Database=AdoDotNet;Trusted_Connection=true";
            string query = "INSERT INTO Users (Username, PasswordHash) VALUES (@Username, @PasswordHash)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordHash", password); // Ideally, hash the password before storing it

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("User added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            this.Close();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string username = textBox_UserName.Text;
            string password = textBox_password.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password cannot be empty.");
                return;
            }
            InsertUser(username, password);
        }
    }
}
