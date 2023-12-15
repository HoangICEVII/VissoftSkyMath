using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.TrueFalse;

namespace Vissoft.Core.Interfaces.IRepository
{
    public interface ITrueFalseRepository
    {
        Task<List<TrueFalseDTO>> ReadByQuizId (int quizId);
        Task<TrueFalseDTO> ReadById(int id);
        Task CreateTrueFalse(int quizId, TrueFalseCreateDTO obj);
        Task UpdateTrueFalse(int id, TrueFalseUpdateDTO obj);
        Task DeleteTrueFalse(int quizId);
    }
}
