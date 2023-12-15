using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.QuizType;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.Application.Services.AdminService
{
    public class AdminQuizTypeService : IAdminQuizTypeService
    {
        private readonly IQuizTypeRepository _quizTypeRepository;
        public AdminQuizTypeService(IQuizTypeRepository quizTypeRepository)
        {
            _quizTypeRepository = quizTypeRepository;
        }

        public Task CreateQuizType(QuizTypeCreateDTO obj)
        {
            return _quizTypeRepository.CreateQuizType(obj);
        }

        public Task DeleteQuizType(int id)
        {
            return _quizTypeRepository.DeleteQuizType(id);
        }

        public Task<List<QuizTypeDTO>> ReadAllQuizType()
        {
            return _quizTypeRepository.ReadAllQuizType();
        }

        public Task<QuizTypeDTO> ReadQuizTypeById(int id)
        {
            return _quizTypeRepository.ReadQuizTypeById(id);
        }

        public Task UpdateQuizType(int id, QuizTypeUpdateDTO obj)
        {
            return _quizTypeRepository.UpdateQuizType(id, obj);
        }
    }
}
