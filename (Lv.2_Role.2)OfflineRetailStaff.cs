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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MikuRetailPro
{
    public partial class OffRS : Form
    {
        private SqlConnection connection;
        public OffRS(SqlConnection connection, string currentuser)
        {
            this.connection = connection;

            InitializeComponent();
            InitCurrentForm();
            label2.Text = currentuser;
        }

        public void InitCurrentForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        public int FindCurrentId()
        {
            int maxId = 0;

            try
            {
                    using (SqlCommand command = new SqlCommand("SELECT MAX(id) FROM offline_order", connection))
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
                textBox1.Text=string.Empty;
                textBox2.Text=string.Empty;
                textBox3.Text = string.Empty;
                button2.Enabled = true;

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
                int id = FindCurrentId();
                id++;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string name = row.Cells["name"].Value.ToString();
                    string price = row.Cells["price"].Value.ToString();
                    string quantity = row.Cells["quantity"].Value.ToString();
                    string username = row.Cells["username"].Value.ToString();
                    string query = "INSERT INTO offline_order (id, name, price, quantity, username) " +
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
                            MessageBox.Show("Push order successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            dataGridView1.Rows.Clear();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
