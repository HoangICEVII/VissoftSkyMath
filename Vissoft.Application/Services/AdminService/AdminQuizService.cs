﻿using System;
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
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.Application.Services.AdminService
{
    public class AdminQuizService : IAdminQuizService
    {
        private readonly IQuizRepository _quizRepository;
        private readonly IFillBlankRepository _fillBlankRepository;
        private readonly IMatchingRepository _matchingRepository;
        private readonly IMultipleChoiceRepository _multipleChoiceRepository;
        private readonly ITrueFalseRepository _trueFalseRepository;
        private readonly IQuizTypeRepository _quizTypeRepository;
        public AdminQuizService(IQuizRepository quizRepository, IFillBlankRepository fillBlankRepository, IMatchingRepository matchingRepository, IMultipleChoiceRepository multipleChoiceRepository, ITrueFalseRepository trueFalseRepository, IQuizTypeRepository quizTypeRepository)
        {
            _quizRepository = quizRepository;
            _fillBlankRepository = fillBlankRepository;
            _matchingRepository = matchingRepository;
            _multipleChoiceRepository = multipleChoiceRepository;
            _trueFalseRepository = trueFalseRepository;
            _quizTypeRepository = quizTypeRepository;
        }


        public async Task CreateQuiz(int exerciseId, int quizTypeId, QuizCreateDTO obj, List<FillBlankCreateDTO>? fillBlankCreateDTO, List<MatchingCreateDTO>? matchingCreateDTO, List<MultipleChoiceCreateDTO>? multipleChoiceCreateDTO, List<TrueFalseCreateDTO>? trueFalseCreateDTO)
        {
            Quiz quiz = await _quizRepository.CreateQuiz(exerciseId, quizTypeId, obj);
            String quizType = _quizTypeRepository.ReturnQuizType(quizTypeId);
            switch(quizType)
            {
                case "Fill in blank":
                    foreach(var item in fillBlankCreateDTO!)
                    {
                        await _fillBlankRepository.CreateFillBlank(quiz.Id, item);
                    }
                    break;
                case "Matching":
                    foreach(var item in matchingCreateDTO!)
                    {
                        await _matchingRepository.CreateMatching(quiz.Id, item);
                    }
                    break;
                case "Multiple choice":
                    foreach(var item in multipleChoiceCreateDTO!)
                    {
                        await _multipleChoiceRepository.CreateMultipleChoice(quiz.Id, item);
                    }
                    break;
                case "True false":
                    foreach(var item in trueFalseCreateDTO!)
                    {
                        await _trueFalseRepository.CreateTrueFalse(quiz.Id, item);
                    }
                    break;
                default: throw new CustomException("An error occurred", 500);
            }
        }

        
        public Task DeleteQuiz(int id)
        {
            try
            {
                _fillBlankRepository.DeleteFillBlank(id);
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, e.StatusCode);
            }
            try
            {
                _matchingRepository.DeleteMatching(id);
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, e.StatusCode);
            }
            try
            {
                _multipleChoiceRepository.DeleteMultipleChoice(id);
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, e.StatusCode);
            }
            try
            {
                _trueFalseRepository.DeleteTrueFalse(id);
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, e.StatusCode);
            }
            return _quizRepository.DeleteQuiz(id);
        }

        public Task UpdateQuiz(int id, QuizUpdateDTO obj)
        {
            return _quizRepository.UpdateQuiz(id, obj);
        }
    }
}
