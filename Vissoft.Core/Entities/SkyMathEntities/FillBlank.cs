
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.Entities.SkyMathEntities
{
    public class FillBlank
    {
        public int Id {  get; set; }
        public string Answer { get; set; } = string.Empty;
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; } = null!;
    }
}
