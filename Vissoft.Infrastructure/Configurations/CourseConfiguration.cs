using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities;

namespace Vissoft.Infrastructure.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("course");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(1000);
            builder.Property(c => c.ImgLink).IsRequired();
            builder.Property(c => c.Color).IsRequired();
            builder.Property(c => c.CreatedDate).HasColumnType("TIMESTAMP");
            builder.Property(c => c.LastModifiedDate).HasColumnType("TIMESTAMP");
            builder.Property(c => c.Status).HasDefaultValue(true);
            builder.HasMany(c => c.CourseTeachers).WithOne(t => t.Course).HasForeignKey(t => t.CourseId);
            builder.HasMany(c => c.Thematics).WithOne(t => t.Course).HasForeignKey(t => t.CourseId);
        }
    }
}
