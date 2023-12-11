using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Vissoft.Infrastructure.Config
{
    internal class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.ToTable("lesson");
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Id).ValueGeneratedOnAdd();
            builder.Property(l => l.Name).IsRequired().HasMaxLength(100);
            builder.Property(l => l.Description).IsRequired().HasMaxLength(1000);
            builder.Property(l => l.CreatedDate).HasColumnType("TIMESTAMP");
            builder.Property(l => l.LastModifiedDate).HasColumnType("TIMESTAMP");
        }
    }
}
