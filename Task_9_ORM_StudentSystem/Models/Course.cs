using System;
using System.Collections.Generic;
using System.Text;

namespace Task_9_ORM_StudentSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public ICollection<StudentCourses> studentCourses { get; set; }
        public ICollection<Resource> resources { get; set; }
        public ICollection<Homework> homeworks { get; set; }
    }
}
