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

        public static string EncryptData(string input)
        {
            using (SHA512 sha512 = SHA512.Create())
            {

                string CustomSalt = "LMAO";
                byte[] saltBytes = Encoding.UTF8.GetBytes(CustomSalt);
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] saltedInput = new byte[saltBytes.Length + inputBytes.Length];

                Buffer.BlockCopy(saltBytes, 0, saltedInput, 0, saltBytes.Length);
                Buffer.BlockCopy(inputBytes, 0, saltedInput, saltBytes.Length, inputBytes.Length);


                byte[] hashBytes = sha512.ComputeHash(saltedInput);
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        protected string ConnectString = "Data Source=.;Initial Catalog=Nova_Retail;Integrated Security=True;MultipleActiveResultSets=True";
        private void Loginusrbtn_Click(object sender, EventArgs e)
        {
            {
                string username = usntxb.Text;
                string password = EncryptData(pwdtxb.Text);
                SqlConnection connection = null;
                try
                {
                    connection = new SqlConnection(ConnectString);
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM [user_account] WHERE username=@username AND password=@password", connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = command.ExecuteReader();
                    string currentuser = usntxb.Text;
                    usntxb.Text = "";  
                    pwdtxb.Text = ""; 
                    if (reader.Read())
                    {
                        string role = reader["role"].ToString();
                        if (role.Trim() == "Admin") 
                        {
                            MessageBox.Show("Login successful!\nHave a nice day Admin!");
                            reader.Close();
                            this.Hide();
                            ACP acp = new ACP(connection);
                            acp.ShowDialog();
                            this.Show();
                        }
                        if (role.Trim() == "Manager") 
                        {
                            MessageBox.Show("Login successful!\nHave a nice day Manager!");
                            reader.Close();
                            this.Hide();
                            MGR mgr = new MGR(connection, currentuser);
                            mgr.ShowDialog();
                            this.Show();
                        }
                        if (role.Trim() == "OffRS")
                        {
                            MessageBox.Show("Login successful!\nHave a nice day Staff!");
                            reader.Close();
                            this.Hide();
                            OffRS offrs = new OffRS(connection, currentuser);
                            offrs.ShowDialog();
                            this.Show();
                        }
                        if (role.Trim() == "OnRS")
                        {
                            MessageBox.Show("Login successful!\nHave a nice day Staff!");
                            reader.Close();
                            this.Hide();
                            OnRS onrs = new OnRS(connection, currentuser);
                            onrs.ShowDialog();
                            this.Show();
                        }
                        if (role.Trim() == "WHS")
                        {
                            MessageBox.Show("Login successful!\nHave a nice day Worker!");
                            reader.Close();
                            this.Hide();
                            WHS whs = new WHS(connection, currentuser);
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

        private void About_btn_Click(object sender, EventArgs e)
        {
            AboutMikuRetailPro abt = new AboutMikuRetailPro();
            abt.ShowDialog();
            this.Show();
        }
    }
}
