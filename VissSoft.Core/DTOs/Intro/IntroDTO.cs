using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.Helper;

namespace VissSoft.Core.DTOs.Intro
{
    public class IntroDTO : BaseEntity
    {
        public int id { get; set; }
        public string title { get; set; } = null!;
        public string content { get; set; } = null!;
    }
}
