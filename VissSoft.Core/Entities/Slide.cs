using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.Helper;

namespace VissSoft.Core.Entities
{
    public class Slide : BaseEntity
    {
        public int id {  get; set; }
        public string imgLink { get; set; } = null!;
        public string slogan { get; set; } = null!;
    }
}
