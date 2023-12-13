using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
namespace Vissoft.Core.Interfaces.IRepository
{
    public interface ICourseRepository
    {
        Task<List<CourseDto>> GetAllCourse();
        Task<CourseDto> GetCourseById(int id);
        Task<List<CourseDto>> GetAllCourseByGradeId(int gradeId);
        Task CreateCourse(CourseCreateDto courseCreateDto);
        Task UpdateCourse(int id, CourseUpdateDto courseUpdateDto);
        Task DeleteCourse(int id);
    }
}
