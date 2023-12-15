using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.DTOs.TrueFalse
{
    public class TrueFalseDTO
    {
        public int Id { get; set; }
        public string? Topic { get; set; }
        public bool Answer { get; set; }
        public int QuizId { get; set; }
    }
}
