using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.FillBlank;

namespace Vissoft.Core.Interfaces.IRepository
{
    public interface IFillBlankRepository
    {
        Task<List<FillBlankDTO>> ReadByQuizId(int  quizId);
        Task<FillBlankDTO> ReadById(int id);
        Task CreateFillBlank(int quizId, FillBlankCreateDTO obj);
        Task UpdateFillBlank(int id, FillBlankUpdateDTO obj);
        Task DeleteFillBlank(int quizId);
    }
}
