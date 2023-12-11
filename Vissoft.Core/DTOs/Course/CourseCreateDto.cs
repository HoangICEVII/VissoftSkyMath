using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.DTOs
{
    public class CourseCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int GradeId { get; set; }
    }
}
