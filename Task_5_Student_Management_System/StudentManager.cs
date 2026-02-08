using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 Properties: 
• List<Student> Students 
• List<Course> Courses 
• List<Instructor> Instructors 
Methods: 
• bool AddStudent(Student student) 
• bool AddCourse(Course course) 
• bool AddInstructor(Instructor instructor) 
• Student FindStudent(int studentId) 
• Course FindCourse(int courseId) 
• Instructor FindInstructor(int instructorId) 
• bool EnrollStudentInCourse(int studentId, int courseId) 
 */
namespace Task_5_Student_Management_System
{
    internal class StudentManager
    {
        public List<Student> Students { get; } = [];
        public List<Course> Courses { get; } = [];
        public List<Instructor> Instructors { get; } = [];

        public bool AddStudent(Student student)
        {
            if (Students.Contains(student))
                return false;
            Students.Add(student);
            return true;
        }

        public bool AddCourse(Course course)
        {
            if (Courses.Contains(course))
                return false;
            Courses.Add(course);
            return true;
        }

        public bool AddInstructor(Instructor instructor)
        {
            if (Instructors.Contains(instructor))
                return false;
            Instructors.Add(instructor);
            return true;
        }

        

        public Student? FindStudent(Guid studentId)
        {
            foreach (Student student in Students)
                if (student.StudentId == studentId)
                    return student;

            return null;
        }

        public Student? FindStudent(string name)
        {
            foreach (Student student in Students)
                if (student.Name == name)
                    return student;
            return null;
        }

        public Course? FindCourse(Guid courseId)
        {
            foreach (Course course in Courses)
                if (course.CourseId == courseId)
                    return course;
            return null;
        }

        public Course? FindCourse(string title)
        {
            foreach (Course course in Courses)
                if (course.Title == title)
                    return course;
            return null;
        }

        public Instructor? FindInstructor(Guid instructorId)
        {
            foreach (Instructor instructor in Instructors)
                if (instructor.InstructorId == instructorId)
                    return instructor;
            return null;
        }

        public Instructor? FindInstructor(string name)
        {
            foreach (Instructor instructor in Instructors)
                if (instructor.Name == name)
                    return instructor;
            return null;
        }

        public bool EnrollStudentInCourse(Guid studentId, Guid courseId)
        {
            Student? student = FindStudent(studentId);
            Course? course = FindCourse(courseId);
            if (student == null || course == null)
                return false;
            return student.Enroll(course);
        }

    }
}
