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
    public class CourseTeacherConfiguration : IEntityTypeConfiguration<CourseTeacher>
    {
        public void Configure(EntityTypeBuilder<CourseTeacher> builder)
        {
            builder.ToTable("courseTeacher");
            builder.HasKey(x => new { x.CourseId, x.TeacherId });
        }
    }
}
