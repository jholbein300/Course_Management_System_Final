using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Management_System_Final.Entity
{
    public class Enrollment
    {
        private int enrollId;
        private int student;
        private int course;

        public Enrollment(int enrollId, int student, int course)
        {
            enrollmentID = enrollId;
            StudentID = student;
            CourseID = course;
        }
        public int enrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
    }
}

