using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
                SqlConnection connection = null;
                try
                {
                    connection = new SqlConnection("Data Source=.;Initial Catalog=Nova_Retail;Integrated Security=True;MultipleActiveResultSets=True");
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM [user_account] WHERE username=@username AND password=@password", connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = command.ExecuteReader();
                    usntxb.Text = "";  
                    pwdtxb.Text = ""; 
                    if (reader.Read())
                    {
                        string role = reader["role"].ToString();
                        if (role.Trim() == "Admin") 
                        {
                            MessageBox.Show("Login successful!\nHave a nice day!");
                            reader.Close();
                            this.Hide();
                            ACP acp = new ACP(connection);
                            acp.ShowDialog();
                            this.Show();
                        }
                        if (role.Trim() == "Manager") 
                        {
                            MessageBox.Show("Login successful!\nHave a nice day!");
                            reader.Close();
                            this.Hide();
                            MGR mgr = new MGR(connection);
                            mgr.ShowDialog();
                            this.Show();
                        }
                        if (role.Trim() == "OffRS")
                        {
                            MessageBox.Show("Login successful!\nHave a nice day!");
                            reader.Close();
                            this.Hide();
                            OffRS offrs = new OffRS(connection);
                            offrs.ShowDialog();
                            this.Show();
                        }
                        if (role.Trim() == "OnRS")
                        {
                            MessageBox.Show("Login successful!\nHave a nice day!");
                            reader.Close();
                            this.Hide();
                            OnRS onrs = new OnRS(connection);
                            onrs.ShowDialog();
                            this.Show();
                        }
                        if (role.Trim() == "WHS")
                        {
                            MessageBox.Show("Login successful!\nHave a nice day!");
                            reader.Close();
                            this.Hide();
                            WHS whs = new WHS(connection);
                            whs.ShowDialog();
                            this.Show();
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
                finally
                {
                    if (connection != null && connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
