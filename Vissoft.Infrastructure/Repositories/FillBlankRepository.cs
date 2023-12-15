using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.FillBlank;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Infrastructure.Data;

namespace Vissoft.Infrastructure.Repositories
{
    public class FillBlankRepository : IFillBlankRepository
    {
        private readonly VissoftDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public FillBlankRepository(VissoftDatabaseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateFillBlank(int quizId, FillBlankCreateDTO obj)
        {
            try
            {
                FillBlank fillBlank = new FillBlank()
                {
                    Answer = obj.Answer,
                    QuizId = quizId,
                };
                await _dbContext.FillBlanks.AddAsync(fillBlank);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task DeleteFillBlank(int quizId)
        {
            try
            {
                List<FillBlank> list = await _dbContext.FillBlanks.Where(x => x.QuizId == quizId).ToListAsync();
                if(list.Count == 0)
                {
                    throw new CustomException("Found nothing to delete", 404);
                }
                _dbContext.FillBlanks.RemoveRange(list);
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

        public async Task<FillBlankDTO> ReadById(int id)
        {
            try
            {
                FillBlank? fillBlank = await _dbContext.FillBlanks.FindAsync(id);
                if (fillBlank == null)
                {
                    throw new CustomException("Found nothing", 404);
                }
                return _mapper.Map<FillBlankDTO>(fillBlank);
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

        public async Task<List<FillBlankDTO>> ReadByQuizId(int quizId)
        {
            try
            {
                return _mapper.Map<List<FillBlankDTO>>(await _dbContext.FillBlanks.Where(x => x.QuizId == quizId).ToListAsync());
            }
            catch (Exception)
            {

                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task UpdateFillBlank(int id, FillBlankUpdateDTO obj)
        {
            try
            {
                FillBlank? fillBlank = await _dbContext.FillBlanks.FindAsync(id);
                if(fillBlank == null)
                {
                    throw new CustomException("Found nothing to update", 404);
                }
                fillBlank.Answer = obj.Answer;
                _dbContext.FillBlanks.Update(fillBlank);
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
