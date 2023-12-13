using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.Entities
{
    public class Thematic
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool Status { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public ICollection<Lesson> Lessons { get; set; } = null!;
    }
}
