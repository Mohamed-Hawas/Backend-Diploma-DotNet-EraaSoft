namespace Task_11_Book_My_Doctor.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        IEnumerable<Doctor>? Doctors { get; set; }

    }
}
