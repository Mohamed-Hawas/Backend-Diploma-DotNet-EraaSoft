using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Task_9_ORM_StudentSystem.Models;

namespace Task_9_ORM_StudentSystem.Configuration
{
    public class ResourceEntityTypeConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            // Name
            builder.Property(s => s.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            // Url
            builder.Property(s => s.Url)
                .IsUnicode(false);
        }
    }
}
