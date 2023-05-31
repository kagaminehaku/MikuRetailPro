using System;
using System.Collections;
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
    public partial class OnRS : Form
    {
        private SqlConnection connection;
        public OnRS(SqlConnection connection, string currentuser)
        {
            InitializeComponent();
            InitCurrentForm();
            this.connection = connection;
            label2.Text = currentuser;
        }

        public int FindCurrentId()
        {
            int maxId = 0;

            try
            {
                using (SqlCommand command = new SqlCommand("SELECT MAX(id) FROM online_order", connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maxId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return maxId;
        }

        public void InitCurrentForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string price = textBox2.Text;
            string quantity = textBox3.Text;
            string username = label2.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(quantity)
                || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            dataGridView1.Rows.Add(name, price, quantity, username);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            button2.Enabled = true;
        }

        private (string, string, string) OpenInputCustomerInfoForm()
        {
            string namecus = string.Empty;
            string addresscus = string.Empty;
            string phoneNumbercus = string.Empty;

            using (InputCustomerInfo inputForm = new InputCustomerInfo())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    namecus = inputForm.CustomerName;
                    addresscus = inputForm.CustomerAddress;
                    phoneNumbercus = inputForm.CustomerPhoneNumber;
                }
            }

            return (namecus, addresscus, phoneNumbercus);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No Data.");
                return;
            }
            try
            {
                (string namecus, string addresscus, string phoneNumbercus) = OpenInputCustomerInfoForm();
                int id = FindCurrentId();
                id++;
                int cuid = id;
                string query2 = "INSERT INTO customer_online (cuid, name, address, phonenumber) " +
                            "VALUES (@Cuid, @Name, @Address, @PhoneNumber)";

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.Parameters.AddWithValue("@Cuid", cuid);
                    command.Parameters.AddWithValue("@Name", namecus);
                    command.Parameters.AddWithValue("@Address", addresscus);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumbercus);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer data push ok!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to push customer data.");
                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string name = row.Cells["name"].Value.ToString();
                    string price = row.Cells["price"].Value.ToString();
                    string quantity = row.Cells["quantity"].Value.ToString();
                    string username = row.Cells["username"].Value.ToString();

                    string query = "INSERT INTO online_order (id, name, price, quantity, username) " +
                                   "VALUES (@Id, @Name, @Price, @Quantity, @Username)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order push successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Order push failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            button2.Enabled = false;
            dataGridView1.Rows.Clear();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
