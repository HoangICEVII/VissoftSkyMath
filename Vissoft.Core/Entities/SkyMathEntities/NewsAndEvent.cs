using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;
using Vissoft.Core.Helper;

namespace Vissoft.Core.Entities.SkyMathEntities
{
    public class NewsAndEvent : IDateTracking
    {
        public int Id { get; set; }
        public string ImageLink { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Overview { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<NewsAndEventAttribute> NewsAndEventAttributes { get; set; } = null!;

    }
}
