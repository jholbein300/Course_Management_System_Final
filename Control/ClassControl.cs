using System;
using System.Collections.Generic;
using Course_Management_System_Final.Entity;

namespace Course_Management_System_Final.Control
{
    public class ClassControl
    {
        DBConnector dB = new DBConnector();
        
        public void addClass(string usn)
        {
            dB.getClass(usn);

        }
    }
}