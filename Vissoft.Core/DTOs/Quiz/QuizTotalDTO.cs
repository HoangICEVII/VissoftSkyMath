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
    public class QuizTotalDTO
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public string? Image { get; set; }
        public float? Mark { get; set; }
        public int ExerciseId { get; set; }
        public int QuizTypeId { get; set; }
        public List<FillBlankDTO>? FillBlanks { get; set; }
        public List<MatchingDTO>? Matchings { get; set; }
        public List<MultipleChoiceDTO>? MultipleChoices { get; set; }
        public List<TrueFalseDTO>? TrueFalses {  get; set; }
    }
}
