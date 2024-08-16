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
    public partial class Borroing : Form
    {
        static string connectionstring = "Server=.\\;Database=AdoDotNet;Trusted_Connection=true";
        public Borroing()
        {
            InitializeComponent();
        }
        private void BorrowBook(int memberId, int bookId)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    SqlCommand checkAvailabilityCmd = new SqlCommand(
                        "SELECT AvailableCopies FROM Books WHERE BookID = @BookID", conn, transaction);
                    checkAvailabilityCmd.Parameters.AddWithValue("@BookID", bookId);
                    int availableCopies = (int)checkAvailabilityCmd.ExecuteScalar();

                    if (availableCopies <= 0)
                    {
                        MessageBox.Show("This book is not available.");
                        return;
                    }


                    SqlCommand borrowCmd = new SqlCommand(
                        "INSERT INTO Borrowings (BookID, MemberID, BorrowDate, DueDate) VALUES (@BookID, @MemberID, @BorrowDate, @DueDate)", conn, transaction);
                    borrowCmd.Parameters.AddWithValue("@BookID", bookId);
                    borrowCmd.Parameters.AddWithValue("@MemberID", memberId);
                    borrowCmd.Parameters.AddWithValue("@BorrowDate", DateTime.Now);
                    borrowCmd.Parameters.AddWithValue("@DueDate", DateTime.Now.AddDays(14));
                    borrowCmd.ExecuteNonQuery();


                    SqlCommand updateCopiesCmd = new SqlCommand(
                        "UPDATE Books SET AvailableCopies = AvailableCopies - 1 WHERE BookID = @BookID", conn, transaction);
                    updateCopiesCmd.Parameters.AddWithValue("@BookID", bookId);
                    updateCopiesCmd.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Book borrowed successfully.");
                    LoadBorrowedBooks(memberId);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadBorrowedBooks(int memberId)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT b.BookID, b.Title, br.BorrowDate, br.DueDate, br.ReturnDate " +
                    "FROM Borrowings br " +
                    "INNER JOIN Books b ON br.BookID = b.BookID " +
                    "WHERE br.MemberID = @MemberID AND br.ReturnDate IS NULL", conn);
                cmd.Parameters.AddWithValue("@MemberID", memberId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            int memberId = int.Parse(textBox1.Text); 
            int bookId = int.Parse(textBox2.Text); 

            BorrowBook(memberId, bookId);
        }
    }
}