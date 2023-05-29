using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            RefreshData();
        }

        public void RefreshData()
        {
            InitDataToRSPWD_DGV();
            InitDataToARS_DGV();
            InitDataToARS2_DGV();
        }

        public void InitDataToRSPWD_DGV()
        {
            try
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
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        public void InitDataToARS_DGV()
        {
            try
            {
                ARS_DGV.Rows.Clear();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT id, name, age, hometown, gender, contact, citizenid FROM user_profile";
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

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public void InitDataToARS2_DGV()
        {
            try
            {
                ARS2_DGV.Rows.Clear();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT id, name, age, hometown, gender, contact, citizenid FROM user_profile";
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

                            bool isAccountYet = IsAccountYet(idValue); // Check if the user account exists

                            if (isAccountYet)
                            {
                                continue; // Skip adding the row but continue with the next iteration
                            }

                            ARS2_DGV.Rows.Add(rowValues.ToArray());
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private bool IsThatAdmin(int userId)
        {
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT role FROM user_account WHERE id = @userId";
                command.Parameters.AddWithValue("@userId", userId);
                object result = command.ExecuteScalar();
                string role = result?.ToString(); // Null check before calling ToString()
                return (role != null && role.Trim() == "Admin"); // Check for null and then compare role
            }
        }

        private bool IsAccountYet(int userId)
        {
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM user_account WHERE id = @userId";
                command.Parameters.AddWithValue("@userId", userId);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RefreshData();
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
            RefreshData();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Addcomp();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Removecomp();
        }

        public void Addcomp()
        {
            label0.Enabled = false;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            textBox0.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox0.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            Add_Staff.Enabled = true;
            Rm_Staff.Enabled = false;
            GETSTAFF_DATA.Enabled = false;
            ED_Staff.Enabled = false;
        }

        public void Removecomp()
        {
            label0.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            textBox0.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox0.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            Add_Staff.Enabled = false;
            Rm_Staff.Enabled = true;
            GETSTAFF_DATA.Enabled = true;
            ED_Staff.Enabled = false;
        }

        public void Editcomp()
        {
            label0.Enabled = false;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            textBox0.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox0.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            Add_Staff.Enabled = false;
            Rm_Staff.Enabled = false;
            GETSTAFF_DATA.Enabled = true;
            ED_Staff.Enabled = true;
        }

        private void Add_Staff_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string age = textBox2.Text;
                string hometown = textBox3.Text;
                string gender = textBox4.Text;
                string contact = textBox5.Text;
                string citizenId = textBox6.Text;

                // Check if any of the textboxes are empty
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(hometown)
                    || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(citizenId))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                string query = "INSERT INTO user_profile (name, age, hometown, gender, contact, citizenid) " +
                               "VALUES (@Name, @Age, @Hometown, @Gender, @Contact, @CitizenID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Hometown", hometown);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@CitizenID", citizenId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert data.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            Addcomp();
            RefreshData();
        }


        private void ED_Staff_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox0.Text;
                string name = textBox1.Text;
                string age = textBox2.Text;
                string hometown = textBox3.Text;
                string gender = textBox4.Text;
                string contact = textBox5.Text;
                string citizenId = textBox6.Text;

                // Check if any of the textboxes are empty
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(hometown)
                    || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(citizenId))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                string query = "UPDATE user_profile SET name = @Name, age = @Age, hometown = @Hometown, " +
                               "gender = @Gender, contact = @Contact, citizenid = @CitizenID WHERE id = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Hometown", hometown);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@CitizenID", citizenId);
                    command.Parameters.AddWithValue("@ID", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update data.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            Editcomp();
            RefreshData();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Editcomp();
        }

        private void Rm_Staff_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox0.Text;

                // Check if the ID is empty
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please enter an ID.");
                    return;
                }

                // Delete record from user_account table first
                string accountQuery = "DELETE FROM user_account WHERE id = @ID";
                using (SqlCommand accountCommand = new SqlCommand(accountQuery, connection))
                {
                    accountCommand.Parameters.AddWithValue("@ID", id);
                    int accountRowsAffected = accountCommand.ExecuteNonQuery();

                    // Delete record from user_profile table
                    string profileQuery = "DELETE FROM user_profile WHERE id = @ID";
                    using (SqlCommand profileCommand = new SqlCommand(profileQuery, connection))
                    {
                        profileCommand.Parameters.AddWithValue("@ID", id);
                        int profileRowsAffected = profileCommand.ExecuteNonQuery();

                        if (profileRowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.");
                        }
                    }

                    if (accountRowsAffected > 0)
                    {
                        MessageBox.Show("Account deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Account of this Profile not found.");
                    }
                }
                Removecomp();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void GETSTAFF_DATA_Click(object sender, EventArgs e)
        {
            textBox0.Text = ARS_DGV.CurrentRow.Cells["id1"].Value.ToString();
            textBox1.Text = ARS_DGV.CurrentRow.Cells["name1"].Value.ToString();
            textBox3.Text = ARS_DGV.CurrentRow.Cells["age1"].Value.ToString();
            textBox2.Text = ARS_DGV.CurrentRow.Cells["hometown1"].Value.ToString();
            textBox4.Text = ARS_DGV.CurrentRow.Cells["gender1"].Value.ToString();
            textBox5.Text = ARS_DGV.CurrentRow.Cells["contact1"].Value.ToString();
            textBox6.Text = ARS_DGV.CurrentRow.Cells["citizenid1"].Value.ToString();
            RefreshData();
        }

        private void BINDSTAFF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox10.Text))
            {
                MessageBox.Show("Please select a Profile.");
                return;
            }
            textBox10.Text = ARS2_DGV.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            try
            {
                string username = textBox7.Text;
                string password = textBox8.Text;
                string rpassword = textBox9.Text;
                string id = textBox10.Text;
                string role = textBox11.Text;   


                // Check if any of the textboxes are empty
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(rpassword))
                {
                    MessageBox.Show("Please fill in all fields.");     
                    return;
                }
                if ( password != rpassword)
                {
                    MessageBox.Show("Password does not match.");
                    return;
                }
                if (password.Length <= 8)
                {
                    MessageBox.Show("Password not long enough (>8 characters).");
                    return;
                }
                string query = "INSERT INTO user_account (username, password, id, role) " +
                               "VALUES (@username, @password, @id, @role)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@role", role);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert data.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            Addcomp();
            RefreshData();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.Text = "Admin";
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.Text = "OnRS";
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.Text = "Manager";
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.Text = "OffRS";
        }
    }
}
