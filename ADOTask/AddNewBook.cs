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

    public partial class AddNewBook : Form
    {
        static string connectionstring = "Server=.\\;Database=AdoDotNet;Trusted_Connection=true";
        public AddNewBook()
        {
            InitializeComponent();

            books = new Books();
            bindingsource = new BindingSource();
            bindingsource.DataSource = books;
            textBox_Title.DataBindings.Add("text", bindingsource, nameof(books.Title));
            textBox_Author.DataBindings.Add("text", bindingsource, nameof(books.Author));
            textBox_ISBN.DataBindings.Add("text", bindingsource, nameof(books.ISBN));
            textBox_PublicationYear.DataBindings.Add("text", bindingsource, nameof(books.PublicationYear));
            textBox_TotalCopies.DataBindings.Add("text", bindingsource, nameof(books.TotalCopies));
            textBox_AvailableCopies.DataBindings.Add("text", bindingsource, nameof(books.AvailableCopies));
        }

        private Books books;
        BindingSource bindingsource;
        public void InsertBooks(Books books)
        {

            string query = @"INSERT INTO Books(Title,Author,ISBN,PublicationYear,TotalCopies,AvailableCopies)
                            VALUES(@Title,@Author,@ISBN,@PublicationYear,@TotalCopies,@AvailableCopies);
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@Title", SqlDbType.NVarChar, 100).Value = books.Title;
                command.Parameters.Add("@Author", SqlDbType.NVarChar, 100).Value = books.Author;
                command.Parameters.Add("@ISBN", SqlDbType.NVarChar, 100).Value = books.ISBN;
                command.Parameters.Add("@PublicationYear", SqlDbType.NVarChar, 100).Value = books.PublicationYear;
                command.Parameters.Add("@TotalCopies", SqlDbType.NVarChar, 100).Value = books.TotalCopies;
                command.Parameters.Add("@AvailableCopies", SqlDbType.NVarChar, 100).Value = books.AvailableCopies;


                connection.Open();
                var result = command.ExecuteScalar();
                int booksId = Convert.ToInt32(result);
                books.BookID = booksId;
                connection.Close();
            }

        }

        private void button_EnterAddNewBook_Click(object sender, EventArgs e)
        {
            InsertBooks(books);
            MessageBox.Show($"The Member Insert IS SuccessFull With ID Is-->{books.BookID}");
            this.Close();
        }

        private void button_searshBooks_Click(object sender, EventArgs e)
        {

        }
    }
}
