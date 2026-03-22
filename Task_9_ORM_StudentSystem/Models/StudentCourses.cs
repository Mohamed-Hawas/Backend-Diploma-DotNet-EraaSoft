using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace Task_9_ORM_StudentSystem.Models
{
    public class StudentCourses
    {
        public int StudentId { get; set; }
        public Student student { get; set; }

        public int CourseId { get; set; }
        public Course course { get; set; }
    }
}
