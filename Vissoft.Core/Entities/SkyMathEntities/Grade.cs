using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities.SkyMathEntities;

namespace Vissoft.Core.Entities.SkyMathEntities
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Course> Courses { get; set; } = null!;
    }
}
