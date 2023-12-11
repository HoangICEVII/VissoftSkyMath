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
        Task<List<LessonDto>> GetLesson(int lessonId);
        Task AddNewLesson(LessonCreateDto lessonCreateDto);
        Task UpdateLesson(LessonUpdateDto lessonUpdateDto);
        Task DeleteLesson(int lessonId);
    }
}
