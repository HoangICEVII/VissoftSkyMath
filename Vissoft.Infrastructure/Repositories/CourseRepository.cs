using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IRepository;

namespace Vissoft.Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public Task AddNewCourse(CourseCreateDto courseCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCourse(int couseId)
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseDto>> GetCourse(int pageIndex, int numberOfItem)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourse(CourseUpdateDto courseUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
