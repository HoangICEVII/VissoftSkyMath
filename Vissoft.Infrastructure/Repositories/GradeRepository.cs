using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IRepository;

namespace Vissoft.Infrastructure.Repositories
{
    public class GradeRepository : IGradeRepository
    {
        public Task AddNewGrade(GradeCreateDto gradeCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGrade(int gradeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GradeDto>> GetGrade()
        {
            throw new NotImplementedException();
        }

        public Task UpdateGrade(GradeUpdateDto gradeUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
