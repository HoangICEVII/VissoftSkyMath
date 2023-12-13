using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;

namespace Vissoft.Core.Interfaces.IService.IAdminService
{
    public interface IAdminCourseService
    {
        Task<List<CourseDto>> GetAllCourse();
        Task<CourseDto> GetCourseDetail(int id);
        Task CreateCourse(CourseCreateDto courseCreateDto);
        Task UpdateCourse(int id,CourseUpdateDto courseUpdateDto);
        Task DeleteCourse(int id);
    }
}
