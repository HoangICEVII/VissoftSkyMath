using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.Application.Services.AdminService
{
    public class AdminCourseService : IAdminCourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly IThematicRepository _thematicRepository;

        public AdminCourseService(ICourseRepository courseRepository,
                                  IThematicRepository thematicRepository,
                                  ILessonRepository lessonRepository)
        {
            _courseRepository = courseRepository;
            _thematicRepository = thematicRepository;
            _lessonRepository = lessonRepository;
        }
        public async Task CreateCourse(CourseCreateDto courseCreateDto)
        {
            await _courseRepository.CreateCourse(courseCreateDto);
        }

        public async Task DeleteCourse(int id)
        {
            await _courseRepository.DeleteCourse(id);
        }

        public async Task<List<CourseDto>> GetAllCourse()
        {
            return await _courseRepository.GetAllCourse();
        }

        public async Task<CourseDto> GetCourseDetail(int id)
        {
            var courseData = await _courseRepository.GetCourseById(id);
            courseData.ThematicDtos = await _thematicRepository.GetThematicByCourseId(id);
            foreach(var item in courseData.ThematicDtos)
            {
                item.LessonDtos = await _lessonRepository.GetLessonByThematicId(item.Id);
            }
            return courseData;
        }

        public async Task UpdateCourse(int id, CourseUpdateDto courseUpdateDto)
        {
            await _courseRepository.UpdateCourse(id, courseUpdateDto);
        }
    }
}
