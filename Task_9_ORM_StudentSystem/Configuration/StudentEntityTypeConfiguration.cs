using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Task_9_ORM_StudentSystem.Models;

namespace Task_9_ORM_StudentSystem.Configuration
{
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Name
            builder.Property(s => s.Name)
                .HasMaxLength(100)
                .IsUnicode();

            // Phone Number
            builder.Property(s => s.PhoneNumber)
                .HasMaxLength(11)
                .IsRequired(false);

            //Birthday
            builder.Property(s => s.Birthday)
                .IsRequired(false);
        }
    }
}
