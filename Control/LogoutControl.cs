using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_System_Final.Control
{
    public class LogoutControl
    {
        DBConnector db = new DBConnector();
        public void logout(string username)
        {
            db.SaveLogOut(username);

        }
    }
}