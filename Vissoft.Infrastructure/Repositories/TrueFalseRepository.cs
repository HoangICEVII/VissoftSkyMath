using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.TrueFalse;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Infrastructure.Data;

namespace Vissoft.Infrastructure.Repositories
{
    public class TrueFalseRepository : ITrueFalseRepository
    {
        private readonly VissoftDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public TrueFalseRepository(VissoftDatabaseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateTrueFalse(int quizId, TrueFalseCreateDTO obj)
        {
            try
            {
                TrueFalse trueFalse = new TrueFalse()
                {
                    Topic = obj.TrueFalseTopic,
                    Answer = obj.TrueFalseAnswer,
                    QuizId = quizId,
                };
                await _dbContext.TrueFalses.AddAsync(trueFalse);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task DeleteTrueFalse(int quizId)
        {
            try
            {
                List<TrueFalse> list = await _dbContext.TrueFalses.Where(x => x.QuizId == quizId).ToListAsync();
                if (list.Count == 0)
                {
                    throw new CustomException("Found nothing to delete", 404);
                }
                _dbContext.TrueFalses.RemoveRange(list);
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

        public async Task<TrueFalseDTO> ReadById(int id)
        {
            try
            {
                TrueFalse? trueFalse = await _dbContext.TrueFalses.FindAsync(id);
                if (trueFalse == null)
                {
                    throw new CustomException("Found nothing", 404);
                }
                return _mapper.Map<TrueFalseDTO>(trueFalse);
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

        public async Task<List<TrueFalseDTO>> ReadByQuizId(int quizId)
        {
            try
            {
                return _mapper.Map<List<TrueFalseDTO>>(await _dbContext.TrueFalses.Where(x => x.QuizId == quizId).ToListAsync());
            }
            catch (Exception)
            {

                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task UpdateTrueFalse(int id, TrueFalseUpdateDTO obj)
        {
            try
            {
                TrueFalse? trueFalse = await _dbContext.TrueFalses.FindAsync(id);
                if (trueFalse == null)
                {
                    throw new CustomException("Found nothing to update", 404);
                }
                trueFalse.Topic = obj.TrueFalseTopic;
                trueFalse.Answer = obj.TrueFalseAnswer;
                _dbContext.TrueFalses.Update(trueFalse);
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
