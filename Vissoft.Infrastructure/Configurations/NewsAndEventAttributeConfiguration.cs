using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;

namespace Vissoft.Infrastructure.Configurations
{
    public class NewsAndEventAttributeConfiguration : IEntityTypeConfiguration<NewsAndEventAttribute>
    {
        public void Configure(EntityTypeBuilder<NewsAndEventAttribute> builder)
        {
            builder.ToTable("newsAndEventAttribute");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

        }
    }
}
