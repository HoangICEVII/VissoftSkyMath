using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.FillBlank;
using Vissoft.Core.DTOs.Matching;
using Vissoft.Core.DTOs.MultipleChoice;
using Vissoft.Core.DTOs.TrueFalse;

namespace Vissoft.Core.DTOs.Quiz
{
    public class QuizRequest
    {
        public QuizCreateDTO QuizCreateDTO { get; set; } = null!;
        public List<FillBlankCreateDTO>? FillBlankCreateDTOs { get; set; }
        public List<MatchingCreateDTO>? MatchingCreateDTOs { get; set; }
        public List<MultipleChoiceCreateDTO>? MultipleChoiceCreateDTOs { get; set; }
        public List<TrueFalseCreateDTO>? TrueFalseCreateDTOs { get; set; }
    }
}
