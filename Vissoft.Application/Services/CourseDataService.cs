using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.Application.Services
{
    public class CourseDataService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseDataService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Task<List<CourseDto>> GetAllCourse()
        {
            throw new NotImplementedException();
        }
        public Task<CourseDto> GetCourseById(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<List<CourseDto>> GetAllCourseByGradeId(int gradeId)
        {
            return await _courseRepository.GetAllCourseByGradeId(gradeId);
        }
        public async Task CreateCourse(CourseCreateDto courseCreateDto)
        {
            await _courseRepository.CreateCourse(courseCreateDto);
        }
        public async Task UpdateCourse(CourseUpdateDto courseUpdateDto)
        {
            await _courseRepository.UpdateCourse(courseUpdateDto);
        }
        public async Task DeleteCourse(int couseId)
        {
            await _courseRepository.DeleteCourse(couseId);
        }
    }
}
