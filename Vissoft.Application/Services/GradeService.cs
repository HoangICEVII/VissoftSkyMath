using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Core.Interfaces.IService;

namespace Vissoft.Application.Services
{
    public class GradeService : IGradeService
    {
        private readonly IGradeRepository _gradeRepository;
        public GradeService(IGradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }
        public async Task<List<GradeDto>> GetGrade()
        {
            return await _gradeRepository.GetGrade();
        }
        public async Task AddNewGrade(GradeCreateDto gradeCreateDto)
        {
            await _gradeRepository.AddNewGrade(gradeCreateDto);
        }

        public async Task DeleteGrade(int gradeId)
        {
            await _gradeRepository.DeleteGrade(gradeId);
        }
    }
}
