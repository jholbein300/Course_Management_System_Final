using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Course_Management_System_Final.Entity;

namespace Course_Management_System_Final.Entity
{
    public class Course
    {
        private int courseId;
        private string name;
        private int instructor;

        public Course(int courseId, string name, int isntructor)
        {
            CourseId = courseId;
            Name = name;
            Instructor = isntructor;
        }

        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Instructor { get; set; }
    }
}

