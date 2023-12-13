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
        public Task CreateLesson(LessonCreateDto lessonCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLesson(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LessonDto>> GetLessonByThematicId(int thematicId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLesson(int id, LessonUpdateDto lessonUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
