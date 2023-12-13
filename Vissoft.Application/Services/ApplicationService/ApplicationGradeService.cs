using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.Application.Services.ApplicationService
{
    public class ApplicationGradeService : IApplicationGradeService
    {
        private readonly IGradeRepository _gradeRepository;
        public ApplicationGradeService(IGradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }
        public async Task<List<GradeDto>> GetAllGrade()
        {
            return await _gradeRepository.GetAllGrade();
        }
    }
}
