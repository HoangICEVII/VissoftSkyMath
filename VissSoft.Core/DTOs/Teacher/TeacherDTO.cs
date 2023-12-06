using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.Helper;

namespace VissSoft.Core.DTOs.Teacher
{
    public class TeacherDTO : BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; } = null!;
        public string avatar { get; set; } = null!;
        public string description { get; set; } = null!;
    }
}
