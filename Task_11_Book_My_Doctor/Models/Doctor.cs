namespace Task_11_Book_My_Doctor.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string PhotoName { get; set; }
        public IEnumerable<Appointment> Appointments { get; set; }

    }
}
