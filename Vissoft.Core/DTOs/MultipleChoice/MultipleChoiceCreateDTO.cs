using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.DTOs.MultipleChoice
{
    public class MultipleChoiceCreateDTO
    {
        public string? MultipleChoiceOptionA { get; set; }
        public string? MultipleChoiceOptionB { get; set; }
        public string? MultipleChoiceOptionC { get; set; }
        public string? MultipleChoiceOptionD { get; set; }
        public string MultipleChoiceAnswer { get; set; } = string.Empty;
    }
}
