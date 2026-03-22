using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Task_9_ORM_StudentSystem.Models;

namespace Task_9_ORM_StudentSystem.Configuration
{
    public class HomeworkEntityTypeConfiguration : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            // Content
            builder.Property(s => s.Content)
                .IsUnicode(false);
        }
    }
}
