using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;

namespace Vissoft.Core.Entities.SkyMathEntities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public string WorkPlace { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public virtual ICollection<CourseTeacher> CourseTeachers { get; set; } = null!;
    }
}
