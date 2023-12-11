using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Avatar { get; set; } = null!;
        public string WorkPlace { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
