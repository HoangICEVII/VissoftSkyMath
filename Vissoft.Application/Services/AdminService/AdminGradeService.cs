using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.Application.Services.AdminService
{
    public class AdminGradeService : IAdminGradeService
    {
        private readonly IGradeRepository _gradeRepository;
        public AdminGradeService(IGradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }
        public async Task CreateGrade(GradeCreateDto gradeCreateDto)
        {
            await _gradeRepository.CreateGrade(gradeCreateDto);
        }

        public async Task DeleteGrade(int id)
        {
            await _gradeRepository.DeleteGrade(id);
        }

        public async Task<List<GradeDto>> GetAllGrade()
        {
            return await _gradeRepository.GetAllGrade();
        }
    }
}
