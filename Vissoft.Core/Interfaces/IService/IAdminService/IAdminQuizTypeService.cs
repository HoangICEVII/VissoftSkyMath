using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.QuizType;

namespace Vissoft.Core.Interfaces.IService.IAdminService
{
    public interface IAdminQuizTypeService
    {
        Task<List<QuizTypeDTO>> ReadAllQuizType();
        Task<QuizTypeDTO> ReadQuizTypeById(int id);
        Task CreateQuizType(QuizTypeCreateDTO obj);
        Task UpdateQuizType(int id, QuizTypeUpdateDTO obj);
        Task DeleteQuizType(int id);
    }
}
