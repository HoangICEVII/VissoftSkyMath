using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Helper;

namespace Vissoft.Core.Entities
{
    public class Course : IDateTracking
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImgLink { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public bool Status { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; } = null!;
        public virtual ICollection<CourseTeacher> CourseTeachers { get; set; } = null!;
        public virtual ICollection<Thematic> Thematics { get; set; } = null!;
    }
}
