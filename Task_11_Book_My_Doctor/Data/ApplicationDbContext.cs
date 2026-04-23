using Microsoft.EntityFrameworkCore;

namespace Task_11_Book_My_Doctor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=BookMyDoctor;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");
        }
    }
}
