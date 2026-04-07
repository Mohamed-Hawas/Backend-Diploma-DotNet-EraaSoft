using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task_9_ORM_StudentSystem.Configuration;
using Task_9_ORM_StudentSystem.Models;

namespace Task_9_ORM_StudentSystem.Data
{
    public class StudentSystemDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=StudentSystem;
                Integrated Security=True;
                Encrypt=True;
                TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new StudentEntityTypeConfiguration().Configure( modelBuilder.Entity<Student>() );
            new CourseEntityTypeConfiguration().Configure(modelBuilder.Entity<Course>());
            new HomeworkEntityTypeConfiguration().Configure(modelBuilder.Entity<Homework>());
            new ResourceEntityTypeConfiguration().Configure(modelBuilder.Entity<Resource>());
            new StudentCoursesEntityTypeConfiguration().Configure(modelBuilder.Entity<StudentCourses>());
        }
    }

}
