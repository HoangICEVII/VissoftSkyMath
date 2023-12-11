using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.DTOs
{
    public class ThematicDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public int Course_id { get; set; }
    }
}
