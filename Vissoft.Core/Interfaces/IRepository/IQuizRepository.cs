using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.Quiz;
using Vissoft.Core.Entities.SkyMathEntities;

namespace Vissoft.Core.Interfaces.IRepository
{
    public interface IQuizRepository
    {
        Task<List<QuizTotalDTO>> GetAllQuizByExerciseId(int exerciseId);
        Task<Quiz> CreateQuiz(int exerciseId, int quizTypeId, QuizCreateDTO obj);
        Task UpdateQuiz(int id, QuizUpdateDTO obj);
        Task DeleteQuiz(int id);
    }
}
