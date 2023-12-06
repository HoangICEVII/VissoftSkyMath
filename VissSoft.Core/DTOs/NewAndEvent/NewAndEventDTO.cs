using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.Helper;

namespace VissSoft.Core.DTOs.NewAndEvent
{
    public class NewAndEventDTO : BaseEntity
    {
        public int id { get; set; }
        public string imgLink { get; set; } = null!;
        public string title { get; set; } = null!;
        public string content { get; set; } = null!;
    }
}
