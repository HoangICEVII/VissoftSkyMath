using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IRepository;

namespace Vissoft.Infrastructure.Repositories
{
    public class LessonRepository : ILessonRepository
    {
        public Task AddNewLesson(LessonCreateDto lessonCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLesson(int lessonId)
        {
            throw new NotImplementedException();
        }

        public Task<List<LessonDto>> GetLesson(int lessonId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLesson(LessonUpdateDto lessonUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
