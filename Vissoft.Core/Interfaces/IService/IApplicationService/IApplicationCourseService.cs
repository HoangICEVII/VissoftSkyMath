using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;

namespace Vissoft.Core.Interfaces.IService.IApplicationService
{
    public interface IApplicationCourseService
    {
        Task<List<CourseDto>> GetAllCourseByGradeId(int gradeId);
        Task<CourseDto> GetCourseDetail(int id);
    }
}