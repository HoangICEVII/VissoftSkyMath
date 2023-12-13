using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.Application.Services.ApplicationService
{
    public class ApplicationCourseService : IApplicationCourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly IThematicRepository _thematicRepository;
        public ApplicationCourseService(ICourseRepository courseRepository,
                                        ILessonRepository lessonRepository,
                                        IThematicRepository thematicRepository)
        {
            _courseRepository = courseRepository;
            _lessonRepository = lessonRepository;
            _thematicRepository = thematicRepository;
        }

        public async Task<List<CourseDto>> GetAllCourseByGradeId(int gradeId)
        {
            return await _courseRepository.GetAllCourseByGradeId(gradeId);
        }

        public async Task<CourseDto> GetCourseDetail(int id)
        {
            var courseData = await _courseRepository.GetCourseById(id);
            courseData.ThematicDtos = await _thematicRepository.GetThematicByCourseId(id);
            foreach (var item in courseData.ThematicDtos)
            {
                item.LessonDtos = await _lessonRepository.GetLessonByThematicId(item.Id);
            }
            return courseData;
        }
    }
}
