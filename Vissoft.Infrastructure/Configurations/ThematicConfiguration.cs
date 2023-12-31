﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vissoft.Core.Entities.SkyMathEntities;

namespace Vissoft.Infrastructure.Configurations
{
    internal class ThematicConfiguration : IEntityTypeConfiguration<Thematic>
    {
        public void Configure(EntityTypeBuilder<Thematic> builder)
        {
            builder.ToTable("thematic");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
            builder.Property(t => t.Status).HasDefaultValue(true);
            builder.HasMany(t => t.Lessons).WithOne(l => l.Thematic).HasForeignKey(l => l.ThematicId);
        }
    }
}
