using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.Helper;

namespace VissSoft.Core.DTOs.Course
{
    public class CourseDTO : BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; } = null!;
        public string imgLink { get; set; } = null!;
        public string color { get; set; } = null!;
    }
}
