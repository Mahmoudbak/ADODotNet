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
    public partial class Member : Form
    {
        static string connectionstring = "Server=.\\;Database=AdoDotNet;Trusted_Connection=true";
        public Member()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            BindTextBoxesToSelectedRow();
        }


        private void button_addMember_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {

            string query = "SELECT * FROM Members";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private Members members;
        private void BindTextBoxesToSelectedRow()
        {

            if (dataGridView1.CurrentRow != null)
            {
                members = new Members();
                textBox_FristName.DataBindings.Clear();
                textBox_lastName.DataBindings.Clear();
                textBox_Email.DataBindings.Clear();
                textBox_Phone.DataBindings.Clear();
                textBox_FristName.DataBindings.Add("Text", dataGridView1.CurrentRow.DataBoundItem, nameof(members.FristName));
                textBox_lastName.DataBindings.Add("Text", dataGridView1.CurrentRow.DataBoundItem, nameof(members.LastName));
                textBox_Email.DataBindings.Add("Text", dataGridView1.CurrentRow.DataBoundItem, nameof(members.Email));
                textBox_Phone.DataBindings.Add("Text", dataGridView1.CurrentRow.DataBoundItem, nameof(members.PhoneNumber));
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewMember().ShowDialog();
            RefreshDataGridView();

        }
        private void RefreshDataGridView()
        {
            string query = "SELECT * FROM Members";

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

        private void button_DeleteMember_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Members?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int MemberID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MemberID"].Value);
                    string query = "DELETE FROM Members WHERE MemberID = @MemberID";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionstring))
                        {
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@MemberID", MemberID);
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                                RefreshDataGridView();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting Member: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Member to delete.");
            }
        }

        private void button_EditeMember_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int memberId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MemberID"].Value);

                string firstName = textBox_FristName.Text;
                string lastName = textBox_lastName.Text;
                string email = textBox_Email.Text;
                string phone = textBox_Phone.Text;

                string query = "UPDATE Members SET FristName = @FristName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber WHERE MemberID = @MemberID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@FristName", firstName);
                            command.Parameters.AddWithValue("@LastName", lastName);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@PhoneNumber", phone);
                            command.Parameters.AddWithValue("@MemberID", memberId);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();

                            RefreshDataGridView();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating member: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a member to edit.");
            }
        }

    }
}

