using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;

namespace Vissoft.Core.Entities.SkyMathEntities
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public string? Image { get; set; }
        public float? Mark {  get; set; }
        public int ExerciseId {  get; set; }
        public int QuizTypeId { get; set; }
        public Exercise Exercise { get; set; } = null!;
        public QuizType QuizType { get; set; } = null!;
        public virtual ICollection<FillBlank> FillBlanks { get; set; } = null!;
        public virtual ICollection<Matching> Matchings { get; set; } = null!;
        public virtual ICollection<MultipleChoice> MultipleChoices { get; set; } = null!;
        public virtual ICollection<TrueFalse> TrueFalses { get; set; } = null!;

    }
}
