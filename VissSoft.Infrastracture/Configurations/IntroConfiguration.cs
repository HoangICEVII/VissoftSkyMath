using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.Entities;

namespace VissSoft.Infrastracture.Configurations
{
    public class IntroConfiguration : IEntityTypeConfiguration<Intro>
    {
        public void Configure(EntityTypeBuilder<Intro> builder)
        {
            builder.ToTable("intro");
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).ValueGeneratedOnAdd();
        }
    }
}
