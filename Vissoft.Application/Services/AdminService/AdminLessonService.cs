using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.Application.Services.AdminService
{
    public class AdminLessonService : IAdminLessonService
    {
        public Task CreateLesson(LessonCreateDto lessonCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLesson(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLesson(int id, LessonUpdateDto lessonUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
