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
    public class FillBlankConfiguration : IEntityTypeConfiguration<FillBlank>
    {
        public void Configure(EntityTypeBuilder<FillBlank> builder)
        {
            builder.ToTable("fillBlank");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.QuizId).IsRequired();
        }
    }
}
