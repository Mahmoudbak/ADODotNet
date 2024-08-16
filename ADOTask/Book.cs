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
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADOTask
{

    public partial class Book : Form
    {
        static string connectionstring = "Server=.\\;Database=AdoDotNet;Trusted_Connection=true";
        public Book()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

        }
        private Books books;
        BindingSource bindingsource;



        private void button_addBook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int bookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookID"].Value);

                string title = textBox_Title.Text;
                string author = textBox_Author.Text;
                string isbn = textBox_ISBN.Text;

                int publicationYear;
                int totalCopies;
                int availableCopies;

                if (!int.TryParse(textBox_PublicationYear.Text, out publicationYear))
                {
                    MessageBox.Show("Please enter a valid number for Publication Year.");
                    return;
                }

                if (!int.TryParse(textBox_TotalCopies.Text, out totalCopies))
                {
                    MessageBox.Show("Please enter a valid number for Total Copies.");
                    return;
                }

                if (!int.TryParse(textBox_AvailableCopies.Text, out availableCopies))
                {
                    MessageBox.Show("Please enter a valid number for Available Copies.");
                    return;
                }

                string query = "UPDATE Books SET Title = @Title, Author = @Author, ISBN = @ISBN, PublicationYear = @PublicationYear, TotalCopies = @TotalCopies, AvailableCopies = @AvailableCopies WHERE BookID = @BookID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Title", title);
                            command.Parameters.AddWithValue("@Author", author);
                            command.Parameters.AddWithValue("@ISBN", isbn);
                            command.Parameters.AddWithValue("@PublicationYear", publicationYear);
                            command.Parameters.AddWithValue("@TotalCopies", totalCopies);
                            command.Parameters.AddWithValue("@AvailableCopies", availableCopies);
                            command.Parameters.AddWithValue("@BookID", bookId);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();

                            RefreshDataGridView();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating book: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to edit.");
            }
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewBook().ShowDialog();
            RefreshDataGridView();
        }


        private void DataGridView1_SelectionChanged3(object? sender, EventArgs e)
        {
            string query = "SELECT * FROM Books";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                if (dataGridView1.CurrentRow != null)
                {
                    textBox_Title.DataBindings.Clear();
                    textBox_Author.DataBindings.Clear();
                    textBox_ISBN.DataBindings.Clear();
                    textBox_PublicationYear.DataBindings.Clear();
                    textBox_TotalCopies.DataBindings.Clear();
                    textBox_AvailableCopies.DataBindings.Clear();

                    textBox_Title.DataBindings.Add("Text", dataTable, "Title");
                    textBox_Author.DataBindings.Add("Text", dataTable, "Author");
                    textBox_ISBN.DataBindings.Add("Text", dataTable, "ISBN");
                    textBox_PublicationYear.DataBindings.Add("Text", dataTable, "PublicationYear");
                    textBox_TotalCopies.DataBindings.Add("Text", dataTable, "TotalCopies");
                    textBox_AvailableCopies.DataBindings.Add("Text", dataTable, "AvailableCopies");
                }
            }
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Books";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                BindTextBoxesToSelectedRow();
            }
        }
        private void BindTextBoxesToSelectedRow()
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox_Title.DataBindings.Clear();
                textBox_Author.DataBindings.Clear();
                textBox_ISBN.DataBindings.Clear();
                textBox_PublicationYear.DataBindings.Clear();
                textBox_TotalCopies.DataBindings.Clear();
                textBox_AvailableCopies.DataBindings.Clear();
                textBox_Title.DataBindings.Add("Text", dataGridView1.CurrentRow.DataBoundItem, "Title");
                textBox_Author.DataBindings.Add("Text", dataGridView1.CurrentRow.DataBoundItem, "Author");
                textBox_ISBN.DataBindings.Add("Text", dataGridView1.CurrentRow.DataBoundItem, "ISBN");
                textBox_PublicationYear.DataBindings.Add("Text", dataGridView1.CurrentRow.DataBoundItem, "PublicationYear");
                textBox_TotalCopies.DataBindings.Add("Text", dataGridView1.CurrentRow.DataBoundItem, "TotalCopies");
                textBox_AvailableCopies.DataBindings.Add("Text", dataGridView1.CurrentRow.DataBoundItem, "AvailableCopies");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            BindTextBoxesToSelectedRow();
        }
        private void RefreshDataGridView()
        {
            string query = "SELECT * FROM Books";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }

        private void button_DeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int bookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookID"].Value);
                    string query = "DELETE FROM Books WHERE BookID = @BookID";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionstring))
                        {
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@BookID", bookId);
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                                RefreshDataGridView();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting book: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }

        }
        private void BindTextBoxesToSelectedRow2()
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox_Title.Text = dataGridView1.CurrentRow.Cells["Title"].Value.ToString();
                textBox_Author.Text = dataGridView1.CurrentRow.Cells["Author"].Value.ToString();
                textBox_ISBN.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
                textBox_PublicationYear.Text = dataGridView1.CurrentRow.Cells["PublicationYear"].Value.ToString();
                textBox_TotalCopies.Text = dataGridView1.CurrentRow.Cells["TotalCopies"].Value.ToString();
                textBox_AvailableCopies.Text = dataGridView1.CurrentRow.Cells["AvailableCopies"].Value.ToString();
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchBooks().ShowDialog();
        }
    }
}
