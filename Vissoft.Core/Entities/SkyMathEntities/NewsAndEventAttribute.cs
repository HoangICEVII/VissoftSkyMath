using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.Entities
{
    public class NewsAndEventAttribute
    {
        public int Id { get; set; }
        public string Source { get; set; } = string.Empty;
        public int NewsAndEventId { get; set; }
        public NewsAndEvent NewsAndEvent { get; set; } = null!;
    }
}
