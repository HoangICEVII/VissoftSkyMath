using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.Helper;

namespace VissSoft.Core.Entities
{
    public class Intro : BaseEntity
    {
        public int id { get; set; }
        public string title { get; set; } = null!;
        public string content { get; set; } = null!;

    }
}
