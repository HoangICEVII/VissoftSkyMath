using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.FillBlank;
using Vissoft.Core.DTOs.Matching;
using Vissoft.Core.DTOs.MultipleChoice;
using Vissoft.Core.DTOs.Quiz;
using Vissoft.Core.DTOs.TrueFalse;
using Vissoft.Core.Entities.SkyMathEntities;

namespace Vissoft.Core.Interfaces.IService.IAdminService
{
    public interface IAdminQuizService
    {
        Task CreateQuiz(int exerciseId, int quizTypeId, QuizCreateDTO obj, FillBlankCreateDTO? fillBlankCreateDTO, MatchingCreateDTO? matchingCreateDTO, MultipleChoiceCreateDTO? multipleChoiceCreateDTO, TrueFalseCreateDTO? trueFalseCreateDTO);
        Task UpdateQuiz(int id, QuizUpdateDTO obj);
        Task DeleteQuiz(int id);
    }
}
