using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.QuizType;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Infrastructure.Data;

namespace Vissoft.Infrastructure.Repositories
{
    public class QuizTypeRepository : IQuizTypeRepository
    {
        private readonly VissoftDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public QuizTypeRepository(VissoftDatabaseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateQuizType(QuizTypeCreateDTO obj)
        {
            try
            {
                QuizType quizType = new QuizType()
                {
                    Name = obj.Name,
                };
                await _dbContext.QuizTypes.AddAsync(quizType);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task DeleteQuizType(int id)
        {
            try
            {
                QuizType? quizType = await _dbContext.QuizTypes.FindAsync(id);
                if (quizType == null)
                {
                    throw new CustomException("Found nothing to delete", 404);
                }
                _dbContext.QuizTypes.Remove(quizType);
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

        public async Task<List<QuizTypeDTO>> ReadAllQuizType()
        {
            try
            {
                return _mapper.Map<List<QuizTypeDTO>>(await _dbContext.QuizTypes.ToListAsync());
            }
            catch (Exception)
            {

                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task<QuizTypeDTO> ReadQuizTypeById(int id)
        {
            try
            {
                QuizType? quizType = await _dbContext.QuizTypes.FindAsync(id);
                if(quizType == null)
                {
                    throw new CustomException("Found nothing", 404);
                }
                return _mapper.Map<QuizTypeDTO>(quizType);
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

        public string ReturnQuizType(int id)
        {
            try
            {
                QuizType? quizType = _dbContext.QuizTypes.Find(id);
                if (quizType == null)
                {
                    throw new CustomException("Found nothing", 404);
                }
                return quizType.Name;
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

        public async Task UpdateQuizType(int id, QuizTypeUpdateDTO obj)
        {
            try
            {
                QuizType? quizType = await _dbContext.QuizTypes.FindAsync(id);
                if (quizType == null)
                {
                    throw new CustomException("Found nothing to update", 404);
                }
                quizType.Name = obj.Name;
                _dbContext.QuizTypes.Update(quizType);
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
