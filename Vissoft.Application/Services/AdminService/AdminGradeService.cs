using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.Application.Services.AdminService
{
    public class AdminGradeService : IAdminGradeService
    {
        public Task CreateGrade(GradeCreateDto gradeCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGrade(int gradeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GradeDto>> GetAllGrade()
        {
            throw new NotImplementedException();
        }
    }
}
