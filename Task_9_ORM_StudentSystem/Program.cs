using Task_9_ORM_StudentSystem.Data;
using Task_9_ORM_StudentSystem.Models;
class Program
{
    public static void Main()
    {
        var context = new StudentSystemDbContext();
        Student emp = new Student
        {
            Name = "Ahmed Saad",
            PhoneNumber = "01009922839",
            RegisteredOn = DateTime.Now,
            Birthday = new DateTime(year: 2000, month: 5, day: 20)
        };
        context.Students.Add(emp);
        context.SaveChanges();
    }
}