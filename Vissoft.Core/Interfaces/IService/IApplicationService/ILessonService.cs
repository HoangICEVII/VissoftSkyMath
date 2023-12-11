using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;

namespace Vissoft.Core.Interfaces.IService.IApplicationService
{
    public interface ILessonService
    {
        Task<List<LessonDto>> GetAllLesson();
        Task<LessonDto> GetLessonById(int id);
        Task<List<LessonDto>> GetAllLessonByThematicId(int thematicId);
        Task CreateLesson(LessonCreateDto lessonCreateDto);
        Task UpdateLesson(LessonUpdateDto lessonUpdateDto);
        Task DeleteLesson(int lessonId);
    }
}