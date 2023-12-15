using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities.SkyMathEntities;

namespace Vissoft.Infrastructure.Configurations
{
    public class CurriculumConfiguration : IEntityTypeConfiguration<Curriculum>
    {
        public void Configure(EntityTypeBuilder<Curriculum> builder)
        {
            builder.ToTable("curriculum");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.CreatedDate).HasColumnType("TIMESTAMP");
            builder.Property(c => c.LastModifiedDate).HasColumnType("TIMESTAMP");
            builder.Property(c => c.Status).HasDefaultValue(true);
            builder.HasMany(c => c.Courses).WithOne(t => t.Curriculum).HasForeignKey(t => t.CurriculumId);
        }
    }
}
