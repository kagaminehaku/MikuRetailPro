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
    public partial class ACP : Form
    {
        public ACP(SqlConnection connection)
        {
            
            InitializeComponent();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT username, id, role FROM user_account";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                List<object> rowValues = new List<object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    rowValues.Add(reader.GetValue(i));
                }

                int roleIndex = reader.GetOrdinal("role"); // Get the index of the "role" column
                string roleValue = reader.GetString(roleIndex); // Get the value of the "role" column as a string

                if (roleValue.Trim() == "0") // Skip rows with role = "0"
                {
                    continue; // Skip adding the row but continue with the next iteration
                }

                AREADGV.Rows.Add(rowValues.ToArray());
                ARESDGV.Rows.Add(rowValues.ToArray());
            }
        }
    }
}
