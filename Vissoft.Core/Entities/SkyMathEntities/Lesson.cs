using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Helper;

namespace Vissoft.Core.Entities.SkyMathEntities
{
    public class Lesson : IDateTracking
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public bool Status { get; set; }
        public int ThematicId { get; set; }
        public Thematic Thematic { get; set; } = null!;
        public virtual ICollection<Resource> Resources { get; set; } = null!;
        public virtual ICollection<Exercise> Exercises { get; set; } = null!;
    }
}
