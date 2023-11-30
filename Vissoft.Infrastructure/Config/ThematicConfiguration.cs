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
    internal class ThematicConfiguration : IEntityTypeConfiguration<Thematic>
    {
        public void Configure(EntityTypeBuilder<Thematic> builder)
        {
            builder.ToTable("thematic");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
            builder.HasMany(t => t.Lessons).WithOne(l => l.Thematic).HasForeignKey(l => l.ThematicId);
        }
    }
}
