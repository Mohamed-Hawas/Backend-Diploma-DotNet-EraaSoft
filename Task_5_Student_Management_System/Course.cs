/*Class: Course 
Properties: 
• int CourseId 
• string Title 
• Instructor Instructor 
Methods: 
• string PrintDetails() */
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5_Student_Management_System
{
    internal class Course(string title, Instructor instructor)
    {
        public Guid CourseId { get; init; } = Guid.NewGuid();
        public string Title { get; set; } = title;
        public Instructor Instructor { get; set; } = instructor;

         public string PrintDetails()
        {
            string details = "";
            details += $"Course ID: {CourseId}\n";
            details += $"Title: {Title}\n";
            details += $"Instructor: {Instructor.Name}\n";
            return details;

        }
    }
}
