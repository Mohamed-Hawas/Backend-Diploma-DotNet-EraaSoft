using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Task_9_ORM_StudentSystem.Models;

namespace Task_9_ORM_StudentSystem.Configuration
{
    public class CourseEntityTypeConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            // Name
            builder.Property(s => s.Name)
                .HasMaxLength(80)
                .IsUnicode();

            // Description
            builder.Property(s => s.Description)
                .IsUnicode()
                .IsRequired(false);
        }
    }
}
