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
        Task<List<CourseDto>> GetCourse();
        Task<List<CourseDto>> GetCourseByGradeId(int gradeId);
        Task AddNewCourse(CourseCreateDto courseCreateDto);
        Task UpdateCourse(CourseUpdateDto courseUpdateDto);
        Task DeleteCourse(int couseId);
    }
}
