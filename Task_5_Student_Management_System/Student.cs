using System.Text;

namespace Task_5_Student_Management_System
{
    internal class Student(string name, int age)
    {
        public Guid StudentId { get; init; } = Guid.NewGuid();
        public string Name { get; init; } = name;
        public int Age { get; set; } = age;

        public List<Course> Courses { init; get; } = new List<Course>();

        public bool Enroll(Course course)
        {
            if (Courses.Count >= 5)
            {
                return false; // Cannot enroll in more than 5 courses
            }
            if (Courses.Contains(course))
            {
                return false; // Already enrolled in this course
            }
            Courses.Add(course);
            return true;
        }
        public string PrintDetails()
        {
            string details = "";
            details += $"Student Id : `{StudentId}`\n";
            details += $"Name : `{Name}`\n";
            details += $"Age : `{Age}`\n";
            details += "Enrolled Courses :\n";
            foreach (var course in Courses)
            {
                details += $"- {course.Title} (Instructor: {course.Instructor.Name})";
            }

            return details;
        }

        internal bool IsEnrolledInCourse(Course course)
        {
            return Courses.Contains(course);
        }
    }
}

