using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Task_9_ORM_StudentSystem.Models;

namespace Task_9_ORM_StudentSystem.Configuration
{
    public class StudentCoursesEntityTypeConfiguration : IEntityTypeConfiguration<StudentCourses>
    {
        public void Configure(EntityTypeBuilder<StudentCourses> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });
        }
    }
}
