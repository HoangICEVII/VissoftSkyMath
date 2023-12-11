using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.Application.Services
{
    public class LessonService : ILessonService
    {
        public Task CreateLesson(LessonCreateDto lessonCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLesson(int lessonId)
        {
            throw new NotImplementedException();
        }

        public Task<List<LessonDto>> GetAllLesson()
        {
            throw new NotImplementedException();
        }

        public Task<List<LessonDto>> GetAllLessonByThematicId(int thematicId)
        {
            throw new NotImplementedException();
        }

        public Task<LessonDto> GetLessonById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLesson(LessonUpdateDto lessonUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
