using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Course;
using VissSoft.Core.DTOs.Intro;
using VissSoft.Core.DTOs.NewAndEvent;
using VissSoft.Core.DTOs.Slide;
using VissSoft.Core.DTOs.Teacher;
using VissSoft.Core.Interfaces.IRepositories;
using VissSoft.Core.Interfaces.IServices;

namespace VissSoft.Application.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;
        public HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }
        public async Task<List<CourseDTO>?> readAllCourse()
        {
            return await _homeRepository.readAllCourse();
        }

        public async Task<List<IntroDTO>?> readAllIntro()
        {
            return await _homeRepository.readAllIntro();
        }

        public async Task<List<NewAndEventDTO>?> readAllNewAndEvent()
        {
            return await _homeRepository.readAllNewAndEvent();
        }

        public async Task<List<SlideDTO>?> readAllSlide()
        {
            return await _homeRepository.readAllSlide();
        }

        public async Task<List<TeacherDTO>?> readAllTeacher()
        {
            return await _homeRepository.readAllTeacher();
        }

        public async Task<CourseDTO?> readByCourseId(int id)
        {
            return await _homeRepository.readByCourseId(id);
        }

        public async Task<IntroDTO?> readByIntroId(int id)
        {
            return await _homeRepository.readByIntroId(id);
        }

        public async Task<NewAndEventDTO?> readByNewAndEventId(int id)
        {
            return await _homeRepository.readByNewAndEventId(id);
        }

        public async Task<SlideDTO?> readBySlideId(int id)
        {
            return await _homeRepository.readBySlideId(id);
        }

        public async Task<TeacherDTO?> readByTeacherId(int id)
        {
            return await _homeRepository.readByTeacherId(id);
        }
    }
}
