using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public bool Status { get; set; }
        public Grade Grade { get; set; }
        public int GradeId { get; set; }
        public ICollection<Thematic> Thematics { get; set; }
    }
}
