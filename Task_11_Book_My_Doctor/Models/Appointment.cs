namespace Task_11_Book_My_Doctor.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Note { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
    }
}
