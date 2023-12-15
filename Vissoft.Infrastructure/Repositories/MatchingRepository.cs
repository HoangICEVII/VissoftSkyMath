using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.Matching;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Infrastructure.Data;

namespace Vissoft.Infrastructure.Repositories
{
    public class MatchingRepository : IMatchingRepository
    {
        private readonly VissoftDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public MatchingRepository(VissoftDatabaseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateMatching(int quizId, MatchingCreateDTO obj)
        {
            try
            {
                Matching matching = new Matching()
                {
                    ASide = obj.MatchingASide,
                    BSide = obj.MatchingBSide,
                    QuizId = quizId,
                };
                await _dbContext.Matchings.AddAsync(matching);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task DeleteMatching(int quizId)
        {
            try
            {
                List<Matching> list = await _dbContext.Matchings.Where(x => x.QuizId == quizId).ToListAsync();
                if (list.Count == 0)
                {
                    throw new CustomException("Found nothing to delete", 404);
                }
                _dbContext.Matchings.RemoveRange(list);
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

        public async Task<MatchingDTO> ReadById(int id)
        {
            try
            {
                Matching? matching = await _dbContext.Matchings.FindAsync(id);
                if (matching == null)
                {
                    throw new CustomException("Found nothing", 404);
                }
                return _mapper.Map<MatchingDTO>(matching);
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

        public async Task<List<MatchingDTO>> ReadByQuizId(int quizId)
        {
            try
            {
                return _mapper.Map<List<MatchingDTO>>(await _dbContext.Matchings.Where(x => x.QuizId == quizId).ToListAsync());
            }
            catch (Exception)
            {

                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task UpdateMatching(int id, MatchingUpdateDTO obj)
        {
            try
            {
                Matching? matching = await _dbContext.Matchings.FindAsync(id);
                if (matching == null)
                {
                    throw new CustomException("Found nothing to update", 404);
                }
                matching.ASide = obj.MatchingASide;
                matching.BSide = obj.MatchingBSide;
                _dbContext.Matchings.Update(matching);
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
