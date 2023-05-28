using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MikuRetailPro
{
    public partial class ACP : Form
    {
        private SqlConnection connection;

        public ACP(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
            InitDataToRSPWD_DGV();
            InitDataToARS_DGV();
        }

        public void InitDataToRSPWD_DGV()
        {
            RS_PWD_DGV.Rows.Clear();

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT username, id, role FROM user_account";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<object> rowValues = new List<object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            rowValues.Add(reader.GetValue(i));
                        }

                        int roleIndex = reader.GetOrdinal("role"); // Get the index of the "role" column
                        string roleValue = reader.GetString(roleIndex); // Get the value of the "role" column as a string

                        if (roleValue.Trim() == "Admin") // Skip rows with role = "Admin"
                        {
                            continue; // Skip adding the row but continue with the next iteration
                        }

                        RS_PWD_DGV.Rows.Add(rowValues.ToArray());
                    }
                }
            }
        }

        public void InitDataToARS_DGV()
        {
            ARS_DGV.Rows.Clear();

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT id, name, age FROM user_profile";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<object> rowValues = new List<object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            rowValues.Add(reader.GetValue(i));
                        }

                        int idIndex = reader.GetOrdinal("id"); // Get the index of the "id" column
                        int idValue = reader.GetInt32(idIndex); // Get the value of the "id" column as an int

                        bool isAdmin = IsThatAdmin(idValue); // Check if the user has an "Admin" role

                        if (isAdmin)
                        {
                            continue; // Skip adding the row but continue with the next iteration
                        }

                        ARS_DGV.Rows.Add(rowValues.ToArray());
                    }

                    // Close the SqlDataReader after reading all the rows
                    reader.Close();
                }
            }
        }


        private bool IsThatAdmin(int userId)
        {
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT role FROM user_account WHERE id = @userId";
                command.Parameters.AddWithValue("@userId", userId);
                string role = command.ExecuteScalar()?.ToString();
                return (role == "Admin");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acptb1.Text = RS_PWD_DGV.CurrentRow.Cells["username"].Value.ToString();
            acptb2.Text = RS_PWD_DGV.CurrentRow.Cells["id"].Value.ToString();
            acptb3.Text = RS_PWD_DGV.CurrentRow.Cells["role"].Value.ToString();
        }

        private string PromptForNewPassword()
        {
            using (var form = new System.Windows.Forms.Form { Text = "Change Password", StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen })
            {
                // Set the form icon
                form.Icon = this.Icon;

                using (var textBox = new System.Windows.Forms.TextBox { PasswordChar = '*', Location = new System.Drawing.Point(10, 45), Size = new System.Drawing.Size(200, 20) })
                using (var buttonOk = new System.Windows.Forms.Button { Text = "OK", DialogResult = System.Windows.Forms.DialogResult.OK, Location = new System.Drawing.Point(10, 80) })
                using (var buttonCancel = new System.Windows.Forms.Button { Text = "Cancel", DialogResult = System.Windows.Forms.DialogResult.Cancel, Location = new System.Drawing.Point(100, 80) })
                {
                    form.Controls.AddRange(new System.Windows.Forms.Control[] {
                        new System.Windows.Forms.Label { Text = "Enter a new password:", AutoSize = true, Location = new System.Drawing.Point(10, 20) },
                        textBox,
                        buttonOk,
                        buttonCancel
                    });

                    return form.ShowDialog() == System.Windows.Forms.DialogResult.OK ? textBox.Text : string.Empty;
                }
            }
        }


        private void RS_PWD_Click(object sender, EventArgs e)
        {
            string enteredUsername = acptb1.Text;

            if (string.IsNullOrEmpty(enteredUsername))
            {
                MessageBox.Show("No data entered. Please provide a username.");
                return;
            }

            string newPassword = PromptForNewPassword();

            if (!string.IsNullOrEmpty(newPassword) && newPassword.Length >= 8)
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE user_account SET password = @NewPassword WHERE username = @Username";
                    command.Parameters.AddWithValue("@NewPassword", newPassword);
                    command.Parameters.AddWithValue("@Username", enteredUsername);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password. Username not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid password! The new password must be at least 8 characters long.");
            }
        }

        private void RF_DATA_Click(object sender, EventArgs e)
        {
            InitDataToRSPWD_DGV();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            enablecomp();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            disablecomp();
        }

        public void enablecomp()
        {
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        public void disablecomp()
        {
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
