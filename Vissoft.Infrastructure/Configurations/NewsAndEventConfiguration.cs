using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities;

namespace Vissoft.Infrastructure.Configurations
{
    public class NewsAndEventConfiguration : IEntityTypeConfiguration<NewsAndEvent>
    {
        public void Configure(EntityTypeBuilder<NewsAndEvent> builder)
        {
            builder.ToTable("newsAndEvent");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Overview).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.CreatedDate).HasColumnType("TIMESTAMP");
            builder.Property(x => x.LastModifiedDate).HasColumnType("TIMESTAMP");
            builder.HasMany(c => c.NewsAndEventAttributes).WithOne(t => t.NewsAndEvent).HasForeignKey(t => t.NewsAndEventId);
            builder.Property(x => x.Status).HasDefaultValue(true);
        }
    }
}
