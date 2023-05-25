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

namespace MikuRetailPro
{
    public partial class UsrLoginUI : Form
    {
        public UsrLoginUI()
        {
            InitializeComponent();
        }

        private void quitusrbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void loginusrbtn_Click(object sender, EventArgs e)
        {
            {
                string username = usntxb.Text;
                string password = pwdtxb.Text;

                try
                {
                    SqlConnection connection = new SqlConnection("Data Source=HATSUNEMIKUPOCK;Initial Catalog=MikuRetailPro;Integrated Security=True");

                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM [UserAccount] WHERE username=@Username AND password=@Password", connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Login successful!");
                        string staffNo = reader["StaffNo"].ToString();
                        string accessLevel = reader["AccessLevel"].ToString();
                        if (accessLevel == "1") ;
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
