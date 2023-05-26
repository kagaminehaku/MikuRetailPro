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
            usrusnlabel.Parent = this;
            usrusnlabel.BackColor = Color.Transparent;
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
                    connection = new SqlConnection("Data Source=.;Initial Catalog=Nova_Retail;Integrated Security=True");
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
                        if (role == "0") 
                        {
                            MessageBox.Show("Login successful!\nHave a nice day!");
                            this.Hide();
                            ACP acp = new ACP();
                            acp.ShowDialog();
                            this.Show();
                        }
                        if (role == "1") 
                        {
                            MessageBox.Show("Login successful!\nHave a nice day!");
                            this.Hide();
                            MGR mgr = new MGR();
                            mgr.ShowDialog();
                            this.Show();
                        }
                        if (role == "2")
                        {
                            MessageBox.Show("Login successful!\nHave a nice day!");
                            this.Hide();
                            OffRS offrs = new OffRS();
                            offrs.ShowDialog();
                            this.Show();
                        }
                        if (role == "3")
                        {
                            MessageBox.Show("Login successful!\nHave a nice day!");
                            this.Hide();
                            OnRS onrs = new OnRS();
                            onrs.ShowDialog();
                            this.Show();
                        }
                        if (role == "4")
                        {
                            MessageBox.Show("Login successful!\nHave a nice day!");
                            this.Hide();
                            WHS whs = new WHS();
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
