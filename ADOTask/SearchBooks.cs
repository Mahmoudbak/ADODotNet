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
    public partial class SearchBooks : Form
    {
        static string connectionstring = "Server=.\\;Database=AdoDotNet;Trusted_Connection=true";
        public SearchBooks()
        {
            InitializeComponent();
            search();
        }
  

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            string title = textBox1.Text.Trim();
            string author = textBox2.Text.Trim();
            string isbn = textBox3.Text.Trim();

            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM Books WHERE 1=1");

            if (!string.IsNullOrEmpty(title))
            {
                queryBuilder.Append(" AND Title LIKE @Title");
            }
            if (!string.IsNullOrEmpty(author))
            {
                queryBuilder.Append(" AND Author LIKE @Author");
            }
            if (!string.IsNullOrEmpty(isbn))
            {
                queryBuilder.Append(" AND ISBN LIKE @ISBN");
            }

            string query = queryBuilder.ToString();

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(title))
                    {
                        command.Parameters.AddWithValue("@Title", "%" + title + "%");
                    }
                    if (!string.IsNullOrEmpty(author))
                    {
                        command.Parameters.AddWithValue("@Author", "%" + author + "%");
                    }
                    if (!string.IsNullOrEmpty(isbn))
                    {
                        command.Parameters.AddWithValue("@ISBN", "%" + isbn + "%");
                    }

                    try
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error searching for books: " + ex.Message);
                    }
                }
            }
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

    }
}
