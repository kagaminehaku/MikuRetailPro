using MikuRetailPro.PeopleClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikuRetailPro
{
    public partial class AdminOwnerSetup : Form
    {
        public AdminOwnerSetup()
        {
            InitializeComponent();
        }

        private void quitregbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regusrbtn_Click(object sender, EventArgs e)
        {
            string dataDirectory = "Data";
            string adminOwnerFile = "AdminOwner.txt";
            string username = adregname.Text;
            string password = adregpass.Text;
            string retypePassword = adregpassre.Text;

            if (password != retypePassword)
            {
                MessageBox.Show("Password does not match.");
            }
            else
            {

                AdminOwner adminOwner = new AdminOwner(username, password);
                string adminOwnerFilePath = Path.Combine(dataDirectory, adminOwnerFile);

                using (StreamWriter sw = new StreamWriter(adminOwnerFilePath))
                {
                    sw.WriteLine(username+" "+password);
                }
                MessageBox.Show("Admin Owner Register Complete.");
            }
        }
    }
}
