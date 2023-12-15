using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.Matching;
using Vissoft.Core.DTOs.MultipleChoice;
using Vissoft.Core.DTOs.QuizType;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Infrastructure.Data;

namespace Vissoft.Infrastructure.Repositories
{
    public class MultipleChoiceRepository : IMultipleChoiceRepository
    {
        private readonly VissoftDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public MultipleChoiceRepository(VissoftDatabaseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateMultipleChoice(int quizId, MultipleChoiceCreateDTO obj)
        {
            try
            {
                MultipleChoice multipleChoice = new MultipleChoice()
                {
                    OptionA = obj.MultipleChoiceOptionA,
                    OptionB = obj.MultipleChoiceOptionB,
                    OptionC = obj.MultipleChoiceOptionC,
                    OptionD = obj.MultipleChoiceOptionD,
                    Answer = obj.MultipleChoiceAnswer,
                    QuizId = quizId,
                };
                await _dbContext.MultipleChoices.AddAsync(multipleChoice);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task DeleteMultipleChoice(int quizId)
        {
            try
            {
                List<MultipleChoice> list = await _dbContext.MultipleChoices.Where(x => x.QuizId == quizId).ToListAsync();
                if (list.Count == 0)
                {
                    throw new CustomException("Found nothing to delete", 404);
                }
                _dbContext.MultipleChoices.RemoveRange(list);
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

        public async Task<MultipleChoiceDTO> ReadById(int id)
        {
            try
            {
                MultipleChoice? multipleChoice = await _dbContext.MultipleChoices.FindAsync(id);
                if (multipleChoice == null)
                {
                    throw new CustomException("Found nothing", 404);
                }
                return _mapper.Map<MultipleChoiceDTO>(multipleChoice);
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

        public async Task<List<MultipleChoiceDTO>> ReadByQuizId(int quizId)
        {
            try
            {
                return _mapper.Map<List<MultipleChoiceDTO>>(await _dbContext.MultipleChoices.Where(x => x.QuizId == quizId).ToListAsync());
            }
            catch (Exception)
            {

                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task UpdateMultipleChoice(int id, MultipleChoiceUpdateDTO obj)
        {
            try
            {
                MultipleChoice? multipleChoice = await _dbContext.MultipleChoices.FindAsync(id);
                if (multipleChoice == null)
                {
                    throw new CustomException("Found nothing to update", 404);
                }
                multipleChoice.OptionA = obj.MultipleChoiceOptionA;
                multipleChoice.OptionB = obj.MultipleChoiceOptionB;
                multipleChoice.OptionC = obj.MultipleChoiceOptionC;
                multipleChoice.OptionD = obj.MultipleChoiceOptionD;
                multipleChoice.Answer = obj.MultipleChoiceAnswer;
                _dbContext.MultipleChoices.Update(multipleChoice);
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
