using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.DTOs
{
    public class LessonUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Thematic { get; set; }
        public string Overview { get; set; }
        public string Link { get; set; }
        public bool Status { get; set; }
    }
}
