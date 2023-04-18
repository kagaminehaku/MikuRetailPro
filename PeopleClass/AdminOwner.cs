using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikuRetailPro.PeopleClass
{
    public class AdminOwner
    {
        private string username;
        private string password;
        private int accesslevel;
        // Constructor
        public AdminOwner(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.accesslevel = 3; // Always set to 3 Cuz this is the Highest access level (Owner)
        }
        // Login method
        public bool Login(string username, string password)
        {
            return (this.username == username && this.password == password);
        }
    }
}
 