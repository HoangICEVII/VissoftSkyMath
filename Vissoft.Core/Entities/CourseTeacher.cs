using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.Entities
{
    public class CourseTeacher
    {
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public Course Course { get; set; } = null!;
        public Teacher Teachers { get; set; } = null!;
    }
}
