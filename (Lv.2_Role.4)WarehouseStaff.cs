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
    public partial class WHS : Form
    {
        private SqlConnection connection;
        public WHS(SqlConnection connection,string currentuser)
        {
            this.connection = connection;
            InitializeComponent();
            InitDataDGV1();
        }

        //public void InitDataDGV2()
        //{

        // }

        public void InitDataDGV1()
        {
            try
            {
                string query = "SELECT cuid, name, address, phonenumber, mark FROM customer_online WHERE mark IS NULL";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int cuid = reader.GetInt32(reader.GetOrdinal("cuid"));
                            string name = reader.GetString(reader.GetOrdinal("name"));
                            string address = reader.GetString(reader.GetOrdinal("address"));
                            string phoneNumber = reader.GetString(reader.GetOrdinal("phonenumber"));
                            string mark = reader.IsDBNull(reader.GetOrdinal("mark")) ? null : reader.GetString(reader.GetOrdinal("mark"));

                            if (mark == null)
                            {
                                DGV1.Rows.Add(cuid, name, address, phoneNumber, mark);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            DGV1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cuid = Convert.ToInt32(DGV1.CurrentRow.Cells["cuid"].Value);

            try
            {
                string query = "SELECT name, price, quantity FROM online_order WHERE id = @Cuid";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cuid", cuid);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("name"));
                            int price = reader.GetInt32(reader.GetOrdinal("price"));
                            int quantity = reader.GetInt32(reader.GetOrdinal("quantity"));
                            DGV2.Rows.Add(name, price, quantity);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cuid = Convert.ToInt32(DGV1.CurrentRow.Cells["cuid"].Value);
            try
            {
                string updateQuery = "UPDATE customer_online SET mark = 'done' WHERE cuid = @Cuid";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@Cuid", cuid);
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("MarkComplete");
                    }
                    else
                    {
                        MessageBox.Show("MarkFailed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the mark value: " + ex.Message);
            }
            InitDataDGV1();
        }
    }
}
