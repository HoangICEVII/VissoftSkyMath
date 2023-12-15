using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.MultipleChoice;

namespace Vissoft.Core.Interfaces.IRepository
{
    public interface IMultipleChoiceRepository
    {
        Task<List<MultipleChoiceDTO>> ReadByQuizId(int quizId);
        Task<MultipleChoiceDTO> ReadById(int id);
        Task CreateMultipleChoice(int quizId, MultipleChoiceCreateDTO obj);
        Task UpdateMultipleChoice(int id, MultipleChoiceUpdateDTO obj);
        Task DeleteMultipleChoice(int quizId);
    }
}
