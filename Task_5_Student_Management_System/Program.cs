/*
 Sample Console Menu (on the StudentManager): 
1. Add Student (hint: start with empty list of courses) 
2. Add Instructor 
3. Add Course (hint: select the instructor by id) 
4. Enroll Student in Course 
5. Show All Students 
6. Show All Courses 
7. Show All Instructors 
8. Find the student by id or name 
9. Fine the course by id or name 
10. Exit 
Bonus: 
11. Check if the student enrolled in specific course 
12 Return the instructor name by course name 
 */
namespace Task_5_Student_Management_System
{
    class Program
    {
        
        public static void Main(string[] args)
        {

            List<string> options = [
                "1. Add Student",
                "2. Add Instructor",
                "3. Add Course",
                "4. Enroll Student in Course",
                "5. Show All Students",
                "6. Show All Courses",
                "7. Show All Instructors",
                "8. Find the student by id or name",
                "9. Find the course by id or name",
                "10. Is student enrolled in course?",
                "11. Get instructor name by course name",
                "12. Exit"
            ];

            StudentManager studentManager = new StudentManager();

            Window window = new Window { WindowWidth = 50 };
            window.SetOptions(options);
             

            bool Flag = true;

            while (Flag)
            {
                window.Print();
                int userOption = window.GetUserOption();

                switch (userOption)
                {
                    case 1:
                        // Add Student
                        Console.Write("Enter student name:");
                        string studentName = Console.ReadLine();
                        Console.Write("Enter student age:");
                        int studentAge = int.Parse(Console.ReadLine());
                        Student student = new Student(studentName, studentAge);
                        studentManager.AddStudent(student);
                        break;
                    case 2:
                        // Add Instructor
                        Console.Write("Enter instructor name:");
                        string instructorName = Console.ReadLine();
                        Console.Write("Enter instructor department:");
                        string instructorDepartment = Console.ReadLine();
                        Instructor instructor = new Instructor(instructorName, instructorDepartment);
                        studentManager.AddInstructor(instructor);
                        break;
                    case 3:
                        // Add Course (hint: select the instructor by id) 
                        Console.Write("Enter course name:");
                        string courseName = Console.ReadLine();
                        Console.Write("Enter instructor name:");
                        string instructorName2 = Console.ReadLine();
                        Instructor? instructor2 = studentManager.FindInstructor(instructorName2);
                        if (instructor2 != null)
                        {
                            studentManager.AddCourse(new Course(courseName, instructor2));
                        }
                        else
                        {
                            Console.WriteLine("Instructor not found.");
                        }
                        break;
                    case 4:
                        // Enroll Student in Course
                        Console.Write("Enter student name:");
                        string studentName2 = Console.ReadLine();
                        Console.Write("Enter course name:");
                        string courseName2 = Console.ReadLine();
                        Student? student2 = studentManager.FindStudent(studentName2);
                        Course? course2 = studentManager.FindCourse(courseName2);
                        if (student2 != null && course2 != null)
                        {
                            student2.Enroll(course2);
                        }
                        else
                        {
                            Console.WriteLine("Student or Course not found.");
                        }
                        break;
                    case 5:
                        // Show All Students
                        foreach (Student s in studentManager.Students)
                        {
                            Console.WriteLine(s.PrintDetails());
                        }
                        break;
                    case 6:
                        // Show All Courses
                        foreach (Course c in studentManager.Courses)
                        {
                            Console.WriteLine(c.PrintDetails());
                        }
                        break;
                    case 7:
                        // Show All Instructors
                        foreach (Instructor i in studentManager.Instructors)
                        {
                            Console.WriteLine(i.PrintDetails());
                        }
                        break;
                    case 8:
                        // Find the student by id or name
                        Console.WriteLine("Find student :");
                        Console.WriteLine("Search by \"ID\" or \"Name\":");
                        string input = Console.ReadLine().ToLower();
                        if (input == "id")
                        {
                            Console.WriteLine("Enter student ID:");
                            input = Console.ReadLine();
                            Guid id = Guid.Parse(input);
                            Student? student3 = studentManager.FindStudent(id);
                            if (student3 != null)
                            {
                                Console.WriteLine(student3.PrintDetails());
                            }
                            else
                            {
                                Console.WriteLine("Student not found.");
                            }
                        }else if (input == "name")
                        {
                            Console.WriteLine("Enter student name:");
                            input = Console.ReadLine();
                            Student? student3 = studentManager.FindStudent(input);
                            if (student3 != null)
                            {
                                Console.WriteLine(student3.PrintDetails());
                            }
                            else
                            {
                                Console.WriteLine("Student not found.");
                            }
                        }

                        break;
                    case 9:
                        // Find the course by id or name
                        Console.WriteLine("Find course :");
                        Console.WriteLine("Search by \"ID\" or \"Title\":");
                        string input2 = Console.ReadLine().ToLower();
                        if (input2 == "id")
                        {
                            Console.WriteLine("Enter course ID:");
                            input2 = Console.ReadLine();
                            Guid id = Guid.Parse(input2);
                            Course? course3 = studentManager.FindCourse(id);
                            if (course3 != null)
                            {
                                Console.WriteLine(course3.PrintDetails());
                            }
                            else
                            {
                                Console.WriteLine("Course not found.");
                            }
                        }
                        else if (input2 == "name")
                        {
                            Console.WriteLine("Enter course name:");
                            input2 = Console.ReadLine();
                            Course? course3 = studentManager.FindCourse(input2);
                            if (course3 != null)
                            {
                                Console.WriteLine(course3.PrintDetails());
                            }
                            else
                            {
                                Console.WriteLine("Course not found.");
                            }
                        }

                        break;
                    case 10:
                        // Check if the student enrolled in specific course
                        Console.WriteLine("Enter student id or name:");
                        var studentInput = Console.ReadLine();
                        Student? student4 = studentManager.FindStudent(studentInput);
                        if (student4 != null)
                        {
                            Console.WriteLine("Enter course id or name:");
                            var courseInput2 = Console.ReadLine();
                            Course? course4 = studentManager.FindCourse(courseInput2);
                            if (course4 != null)
                            {
                                if (student4.Courses.Contains(course4))
                                {
                                    Console.WriteLine($"{student4.Name} is enrolled in {course4.Title}.");
                                }
                                else
                                    Console.WriteLine($"{student4.Name} is not enrolled in {course4.Title}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Course not found.");
                        }
                        break;
                    case 11:
                        // Return the instructor name by course name
                        Console.WriteLine("Enter course id or name:");
                        var courseInput3 = Console.ReadLine();
                        Course? course5 = studentManager.FindCourse(courseInput3);
                        if (course5 != null)
                        {
                            Console.WriteLine(course5.Instructor.Name);
                        }
                        else
                        {
                            Console.WriteLine("Course not found.");
                        }
                        break;
                    case 12:
                        // Exit
                        Flag = false;   
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
  
        }

    }
}
