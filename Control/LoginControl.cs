using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Course_Management_System_Final.Entity;

namespace Course_Management_System_Final.control
{
    public class LoginControl
    {
        DBConnector db = new DBConnector();
        public bool Login(string username, string password)
        {
            if (username != null && password != null)
            {
                validateinput(username, password);
                return true;
            }
            else { return false; }
            
        }

        public bool validateinput(string username, string password)
        {
            if (username != null && password.Length >= 8)
            {
                db.GetUser(username, password);
                return true;
            }
            return false;
        }
        
            
        public bool Authenticate(string username, Account account)
        {
            int LoggedInUsn = 0;
            return true;
        }
    }
}