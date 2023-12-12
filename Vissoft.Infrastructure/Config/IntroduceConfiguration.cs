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
    public class IntroduceConfiguration : IEntityTypeConfiguration<Introduce>
    {
        public void Configure(EntityTypeBuilder<Introduce> builder)
        {
            builder.ToTable("introduce");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Status).HasDefaultValue(true);
        }
    }
}
