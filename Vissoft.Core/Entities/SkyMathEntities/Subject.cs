using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Helper;

namespace Vissoft.Core.Entities.SkyMathEntities
{
    public class Subject : IDateTracking
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = null!;
    }
}
