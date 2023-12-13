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
    public class AdminLessonService : IAdminLessonService
    {
        private readonly ILessonRepository _lessonRepository;
        public AdminLessonService(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }
        public async Task CreateLesson(LessonCreateDto lessonCreateDto)
        {
            await _lessonRepository.CreateLesson(lessonCreateDto);
        }

        public async Task DeleteLesson(int id)
        {
            await _lessonRepository.DeleteLesson(id);
        }

        public async Task UpdateLesson(int id, LessonUpdateDto lessonUpdateDto)
        {
            await _lessonRepository.UpdateLesson(id, lessonUpdateDto);
        }
    }
}
