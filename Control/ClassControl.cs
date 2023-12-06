using Course_Management_System_Final.Entity;
using System;
using System.Collections.Generic;

namespace Course_Management_System_Final.Control
{
    public class ClassControl
    {
        DBConnector db = new DBConnector();
        public  void addClass(string usn)
        {
            db.getClass(usn);
        }
        public void submit(Enrollment enrollment)
        {
            db.Save(enrollment);
        }
        public void getList(string usn)
        {
            db.getList(usn);
        }
        public void open(string usn, List<Enrollment> enrollments) 
        { }

    }
}