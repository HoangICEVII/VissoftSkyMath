using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;
using Vissoft.Core.Helper;

namespace Vissoft.Core.Entities.SkyMathEntities
{
    public class Course : IDateTracking
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Info { get; set; } = string.Empty;
        public string ImgLink { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public bool Status { get; set; }
        public int GradeId { get; set; }
        public int SubjectId { get; set; }
        public int? CurriculumId { get; set; }
        public Grade Grade { get; set; } = null!;
        public Subject Subject { get; set; } = null!;
        public Curriculum Curriculum { get; set; } = null!;
        public virtual ICollection<CourseTeacher> CourseTeachers { get; set; } = null!;
        public virtual ICollection<Thematic> Thematics { get; set; } = null!;
    }
}
