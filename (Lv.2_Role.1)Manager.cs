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
    public partial class MGR : Form
    {
        private SqlConnection connection;
        public MGR(SqlConnection connection ,string currentuser)
        {
            this.connection = connection;
            InitializeComponent();
            label1.Text = currentuser;
            InitDataToMGROnDGV();
            InitDataToMGROffDGV();
        }

        public void InitDataToMGROnDGV()
        {
            try
            {
                MGROnO_DGV.Rows.Clear();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT id, name, price, quantity, username FROM online_order";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<object> rowValues = new List<object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowValues.Add(reader.GetValue(i));
                            }
                            MGROnO_DGV.Rows.Add(rowValues.ToArray());
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public void InitDataToMGROffDGV()
        {
            try
            {
                MGROffO_DGV.Rows.Clear();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT id, name, price, quantity,username FROM offline_order";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<object> rowValues = new List<object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowValues.Add(reader.GetValue(i));
                            }
                            MGROffO_DGV.Rows.Add(rowValues.ToArray());
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitDataToMGROnDGV();
            InitDataToMGROffDGV();
        }
    }
}
