using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;

namespace Vissoft.Core.Interfaces.IRepository
{
    public interface IGradeRepository
    {
        Task<List<GradeDto>> GetGrade();
        Task CreateGrade(GradeCreateDto gradeCreateDto);
        Task DeleteGrade(int gradeId);
    }
}
