using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.Quiz;
using Vissoft.Core.DTOs.QuizType;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Infrastructure.Data;

namespace Vissoft.Infrastructure.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly VissoftDatabaseContext _dbContext;
        private IMapper _mapper;
        public QuizRepository(VissoftDatabaseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Quiz> CreateQuiz(int exerciseId, int quizTypeId, QuizCreateDTO obj)
        {
            try
            {
                try
                {
                    Quiz quiz = new Quiz()
                    {
                        Question = obj.Question,
                        Image = obj.Image,  
                        Mark = obj.Mark,
                        ExerciseId = exerciseId,
                        QuizTypeId = quizTypeId,
                    };
                    await _dbContext.Quizzes.AddAsync(quiz);
                    await _dbContext.SaveChangesAsync();
                    return quiz;
                }
                catch (Exception)
                {
                    throw new CustomException("An error occurred", 500);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteQuiz(int id)
        {
            try
            {
                Quiz? quiz = await _dbContext.Quizzes.FindAsync(id);
                if (quiz == null)
                {
                    throw new CustomException("Found nothing to delete", 404);
                }
                _dbContext.Quizzes.RemoveRange(quiz);
                await _dbContext.SaveChangesAsync();
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, e.StatusCode);
            }
            catch (Exception)
            {
                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task<List<QuizTotalDTO>> GetAllQuizByExerciseId(int exerciseId)
        {
            try
            {
                return _mapper.Map<List<QuizTotalDTO>>(await _dbContext.Quizzes.Where(x => x.ExerciseId == exerciseId).ToListAsync());
            }
            catch (Exception)
            {

                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task UpdateQuiz(int id, QuizUpdateDTO obj)
        {
            try
            {
                Quiz? quiz = await _dbContext.Quizzes.FindAsync(id);
                if (quiz == null)
                {
                    throw new CustomException("Found nothing to update", 404);
                }
                quiz.Question = obj.Question;
                quiz.Image = obj.Image;
                quiz.Mark = obj.Mark;
                _dbContext.Quizzes.Update(quiz);
                await _dbContext.SaveChangesAsync();
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, e.StatusCode);
            }
            catch (Exception)
            {
                throw new CustomException("An error occurred", 500);
            }
        }
    }
}
