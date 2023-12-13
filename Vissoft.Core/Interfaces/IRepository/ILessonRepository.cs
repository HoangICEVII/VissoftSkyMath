using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;

namespace Vissoft.Core.Interfaces.IRepository
{
    public interface ILessonRepository
    {
        Task<List<LessonDto>> GetLessonByThematicId(int thematicId);
        Task CreateLesson(LessonCreateDto lessonCreateDto);
        Task UpdateLesson(int id, LessonUpdateDto lessonUpdateDto);
        Task DeleteLesson(int id);
    }
}
