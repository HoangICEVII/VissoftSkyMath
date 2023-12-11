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
    internal class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("grade");
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id).ValueGeneratedOnAdd();
            builder.Property(g => g.Name).IsRequired().HasMaxLength(100);
            builder.HasMany(g => g.Courses).WithOne(c => c.Grade).HasForeignKey(c => c.GradeId);
        }
    }
}
