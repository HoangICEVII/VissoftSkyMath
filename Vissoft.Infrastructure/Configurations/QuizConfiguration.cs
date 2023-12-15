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
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.ToTable("quiz");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.ExerciseId).IsRequired();
            builder.Property(x => x.QuizTypeId).IsRequired();
            builder.HasMany(c => c.FillBlanks).WithOne(t => t.Quiz).HasForeignKey(t => t.QuizId);
            builder.HasMany(c => c.Matchings).WithOne(t => t.Quiz).HasForeignKey(t => t.QuizId);
            builder.HasMany(c => c.MultipleChoices).WithOne(t => t.Quiz).HasForeignKey(t => t.QuizId);
            builder.HasMany(c => c.TrueFalses).WithOne(t => t.Quiz).HasForeignKey(t => t.QuizId);
        }
    }
}
