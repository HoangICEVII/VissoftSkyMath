using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.Exercise;
using Vissoft.Core.DTOs.FillBlank;
using Vissoft.Core.DTOs.Matching;
using Vissoft.Core.DTOs.MultipleChoice;
using Vissoft.Core.DTOs.Quiz;
using Vissoft.Core.DTOs.TrueFalse;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.Application.Services.AdminService
{
    public class AdminExerciseService : IAdminExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IQuizRepository _quizRepository;
        private readonly IQuizTypeRepository _quizTypeRepository;
        private readonly IFillBlankRepository _fillBlankRepository;
        private readonly IMatchingRepository _matchingRepository;
        private readonly IMultipleChoiceRepository _multipleChoiceRepository;
        private readonly ITrueFalseRepository _trueFalseRepository;
        public AdminExerciseService(IExerciseRepository exerciseRepository, IQuizRepository quizRepository, IQuizTypeRepository quizTypeRepository, IFillBlankRepository fillBlankRepository, IMatchingRepository matchingRepository, IMultipleChoiceRepository multipleChoiceRepository, ITrueFalseRepository trueFalseRepository)
        {
            _exerciseRepository = exerciseRepository;
            _quizRepository = quizRepository;
            _quizTypeRepository = quizTypeRepository;
            _fillBlankRepository = fillBlankRepository;
            _matchingRepository = matchingRepository;
            _multipleChoiceRepository = multipleChoiceRepository;
            _trueFalseRepository = trueFalseRepository;
        }

        public async Task CreateExercise(int lessonId, ExerciseCreateDTO obj)
        {
            await _exerciseRepository.CreateExercise(lessonId,obj);
        }

        public async Task DeleteExercise(int id)
        {
            await _exerciseRepository.DeleteExercise(id);
        }

        public async Task<List<ExerciseDTO>> ReadAllExerciseByLessonId(int lessonId)
        {
            return await _exerciseRepository.ReadAllExerciseByLessonId(lessonId);
        }

        public async Task<ExerciseDTO> ReadById(int id)
        {
            List<QuizTotalDTO> list = await _quizRepository.GetAllQuizByExerciseId(id);
            foreach(QuizTotalDTO item in list) { 
                switch(_quizTypeRepository.ReturnQuizType(item.QuizTypeId))
                {
                    case "Fill in blank":
                        item.FillBlanks = await _fillBlankRepository.ReadByQuizId(item.Id);
                        break;
                    case "Matching":
                        item.Matchings = await _matchingRepository.ReadByQuizId(item.Id);
                        break;
                    case "Multiple choice":
                        item.MultipleChoices = await _multipleChoiceRepository.ReadByQuizId(item.Id);
                        break;
                    case "True false":
                        item.TrueFalses = await _trueFalseRepository.ReadByQuizId(item.Id);
                        break;
                    default: throw new CustomException("An error occurred", 500);
                }
            }
            ExerciseDTO obj = await _exerciseRepository.ReadById(id);
            obj.quizTotalDTOs = list;
            return obj;
        }

        public async Task UpdateExercise(int id, ExerciseUpdateDTO obj)
        {
            await _exerciseRepository.UpdateExercise(id,obj);
        }
    }
}
