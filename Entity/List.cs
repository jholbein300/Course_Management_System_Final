using System;
using System.Collections.Generic;
using Course_Management_System_Final.Entity;

namespace Course_Management_System_Final.Entity
{
    public class CourseList<T>
    {
        private LinkedList<T> linkedList;

        public CourseList()
        {
            linkedList = new LinkedList<T>();
        }
    }
}

