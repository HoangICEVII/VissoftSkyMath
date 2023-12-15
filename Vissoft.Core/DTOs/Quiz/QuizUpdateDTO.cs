using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.DTOs.Quiz
{
    public class QuizUpdateDTO
    {
        public string Question { get; set; } = string.Empty;
        public string? Image { get; set; }
        public float? Mark { get; set; }
    }
}
