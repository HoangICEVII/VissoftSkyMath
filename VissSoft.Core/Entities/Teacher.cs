using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.Helper;

namespace VissSoft.Core.Entities
{
    public class Teacher : BaseEntity
    {
        public int id {  get; set; }
        public string name { get; set; } = null!;
        public string avatar { get; set; } = null!;
        public string description { get; set; } = null!;
    }
}
