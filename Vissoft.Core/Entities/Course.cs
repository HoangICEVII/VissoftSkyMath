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
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool Status { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public ICollection<Thematic> Thematics { get; set; }
    }
}
