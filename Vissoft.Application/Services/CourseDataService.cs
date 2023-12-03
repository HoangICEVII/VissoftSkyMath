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
    public class CourseDataService : ICourseDataService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseDataService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Task<List<CourseDto>> GetCourse()
        {
            throw new NotImplementedException();
        }
        public async Task<List<CourseDto>> GetCourseByGradeId(int gradeId)
        {
            return await _courseRepository.GetCourseByGradeId(gradeId);
        }
        public async Task AddNewCourse(CourseCreateDto courseCreateDto)
        {
            await _courseRepository.AddNewCourse(courseCreateDto);
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
