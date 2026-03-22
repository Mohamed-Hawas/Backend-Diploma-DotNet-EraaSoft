using System;
using System.Collections.Generic;
using System.Text;

namespace Task_9_ORM_StudentSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }

        public ICollection<Homework> homeworks { get; set; }
        public ICollection<StudentCourses> studentCourses { get; set; }

    }
}
