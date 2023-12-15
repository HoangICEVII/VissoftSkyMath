using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.Quiz;

namespace Vissoft.Core.DTOs.Exercise
{
    public class ExerciseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int LessonId { get; set; }
        public List<QuizTotalDTO>? quizTotalDTOs { get; set; }
    }
}
