namespace Task_11_Book_My_Doctor.ViewModels
{
    public class AppointmentCreateVM
    {
        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<Department> Departments { get; set; }

        public int DoctorId { get; set; }
        public int DepartmentId { get; set; }

        public string PatientName { get; set; }
        public string PatientEmail { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }
    }
}
