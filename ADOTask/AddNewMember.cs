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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADOTask
{
    public partial class AddNewMember : Form
    {
        static string connectionstring = "Server=.\\;Database=AdoDotNet;Trusted_Connection=true";
        public AddNewMember()
        {
            InitializeComponent();
            members = new Members();
            bindingsource = new BindingSource();
            bindingsource.DataSource = members;
            textBox_FristName.DataBindings.Add("Text", bindingsource, nameof(members.FristName));
            textBox_lastName.DataBindings.Add("Text", bindingsource, nameof(members.LastName));
            textBox_Email.DataBindings.Add("Text", bindingsource, nameof(members.Email));
            textBox_Phone.DataBindings.Add("Text", bindingsource, nameof(members.PhoneNumber));
           
        }
        private Members members;
        BindingSource bindingsource;
        public void InsertMember(Members members)
        {

            string query = @"INSERT INTO Members(FristName,LastName,Email,PhoneNumber,JoinDate)
                            VALUES(@FristName,@Lastname,@Email,@PhoneNumber,@JoinDate);
                             SELECT SCOPE_IDENTITY();";


            using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.Add("@FristName", SqlDbType.NVarChar, 100).Value = members.FristName;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar, 100).Value = members.LastName;
                command.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = members.Email;
                command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 100).Value = members.PhoneNumber;
                command.Parameters.Add("@JoinDate", SqlDbType.NVarChar, 100).Value = members.JoinDate = DateTime.Now;

                sqlConnection.Open();
                var result = command.ExecuteScalar();
                int MemberId = Convert.ToInt32(result);
                members.MemberID = MemberId;
                sqlConnection.Close();
               
            }
        }

        private void button_EnterMember_Click(object sender, EventArgs e)
        {
            InsertMember(members);
            MessageBox.Show($"The Member Insert IS SuccessFull With ID Is-->{members.MemberID}");
            this.Close();
        }

        
    }
}
