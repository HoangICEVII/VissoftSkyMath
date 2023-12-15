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
    public class QuizTypeConfiguration : IEntityTypeConfiguration<QuizType>
    {
        public void Configure(EntityTypeBuilder<QuizType> builder)
        {
            builder.ToTable("quizType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.HasMany(c => c.Quizzes).WithOne(t => t.QuizType).HasForeignKey(t => t.QuizTypeId);
        }
    }
}
