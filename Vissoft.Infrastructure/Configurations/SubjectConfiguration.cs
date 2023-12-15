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
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("subject");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedDate).HasColumnType("TIMESTAMP");
            builder.Property(x => x.LastModifiedDate).HasColumnType("TIMESTAMP");
            builder.Property(x => x.Status).HasDefaultValue(true);
            builder.HasMany(x => x.Courses).WithOne(x => x.Subject).HasForeignKey(x => x.SubjectId);
        }
    }
}
