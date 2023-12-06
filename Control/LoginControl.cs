using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Course_Management_System_Final.Entity;

namespace Course_Management_System_Final.Control
{
    public class LoginControl
    {
        DBConnector db = new DBConnector();
        public bool Login(string username, string password)
        {
            if (username != null && password != null)
            {
                int usnHash = username.GetHashCode();
                int pwdHash = password.GetHashCode();
                Validateinput(usnHash, pwdHash);
                return true;
            }
            else { return false; }
            
        }

        public bool Validateinput(int username, int password)
        {
            if (username != null && password != null)
            {
                db.GetUser(username.ToString(), password.ToString());
                return true;
            }
            return false;
        }
        
            
        public bool Authenticate(string username, Account account)
        {
            int LoggedInUsn = username.GetHashCode();
            return true;
        }
    }
}