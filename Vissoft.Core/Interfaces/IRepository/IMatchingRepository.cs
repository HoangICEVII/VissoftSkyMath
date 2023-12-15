using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.Matching;

namespace Vissoft.Core.Interfaces.IRepository
{
    public interface IMatchingRepository
    {
        Task<List<MatchingDTO>> ReadByQuizId(int  quizId);
        Task<MatchingDTO> ReadById(int id);
        Task CreateMatching(int quizId, MatchingCreateDTO obj);
        Task UpdateMatching(int id, MatchingUpdateDTO obj);
        Task DeleteMatching(int quizId);
    }
}
