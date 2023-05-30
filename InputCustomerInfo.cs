using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MikuRetailPro
{
    public partial class InputCustomerInfo : Form
    {
        public string CustomerName { get; private set; }
        public string CustomerAddress { get; private set; }
        public string CustomerPhoneNumber { get; private set; }
        public InputCustomerInfo()
        {
            InitializeComponent();
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            CustomerName = textBox1.Text;
            CustomerAddress = textBox2.Text;
            CustomerPhoneNumber = textBox3.Text;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox2.Text = string.Empty;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
