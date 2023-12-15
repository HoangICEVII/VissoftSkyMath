using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vissoft.Core.Entities.SkyMathEntities;

namespace Vissoft.Infrastructure.Configurations
{
    internal class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.ToTable("lesson");
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Id).ValueGeneratedOnAdd();
            builder.Property(l => l.Name).IsRequired().HasMaxLength(100);
            builder.Property(l => l.Description).IsRequired(false).HasMaxLength(1000);
            builder.Property(l => l.CreatedDate).HasColumnType("TIMESTAMP");
            builder.Property(l => l.LastModifiedDate).HasColumnType("TIMESTAMP");
            builder.Property(l => l.Status).HasDefaultValue(true);
            builder.Property(l => l.ThematicId).IsRequired();
            builder.HasMany(c => c.Resources).WithOne(t => t.Lesson).HasForeignKey(t => t.LessonId);
            builder.HasMany(c => c.Exercises).WithOne(t => t.Lesson).HasForeignKey(t => t.LessonId);
        }
    }
}
