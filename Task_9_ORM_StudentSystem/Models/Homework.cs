using System;
using System.Collections.Generic;
using System.Text;

namespace Task_9_ORM_StudentSystem.Models
{
    /*Homework: 
o HomeworkId 
o Content (string, linking to a file, not unicode) 
o ContentType (enum – can be Application, Pdf or Zip) 
o SubmissionTime 
o StudentId 
o CourseId */
    public class Homework
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public ContentType CType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }

        public enum ContentType
        {
            Application = 1,
            Pdf = 2,
            Zip = 3
        }
    }
}
