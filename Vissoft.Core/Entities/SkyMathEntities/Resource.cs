using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;

namespace Vissoft.Core.Entities.SkyMathEntities
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? Time { get; set; }
        public int? Rating { get; set; }
        public string Link { get; set; } = string.Empty;

        public int LessonId { get; set; }
        public int ResourceTypeId { get; set; }
        public Lesson Lesson { get; set; } = null!;
        public ResourceType ResourceType { get; set; } = null!;
    }
}
