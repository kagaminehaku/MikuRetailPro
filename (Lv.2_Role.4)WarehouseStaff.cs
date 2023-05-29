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
    public partial class WHS : Form
    {
        public WHS(SqlConnection connection,string currentuser)
        {
            InitializeComponent();
        }
    }
}
