
namespace Task_5_Student_Management_System
{
    internal class Instructor(string name, string specialization)
    {
        public Guid InstructorId { init; get; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        public string Specialization { get; set; } = specialization;

        public string PrintDetails()
        {
            string details = "";
            details += $"Instructor ID: {InstructorId}\n";
            details += $"Name: {Name}\n";
            details += $"Specialization: {Specialization}\n";
            return details;
        }

        
    }
}
