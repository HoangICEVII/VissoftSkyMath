using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities;

namespace Vissoft.Infrastructure.Config
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
