using System;
using System.Collections.Generic;

namespace Course_Management_System_Final.Control
{
    public static class ClassControl
    {
        public static void addClass(string usn)
        {
            DBConnector.GetUser(usn, usn);
        }
    }
}