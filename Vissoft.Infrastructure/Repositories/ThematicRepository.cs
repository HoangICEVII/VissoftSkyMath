using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IRepository;

namespace Vissoft.Infrastructure.Repositories
{
    public class ThematicRepository : IThematicRepository
    {
        public Task CreateThematic(ThematicCreateDto thematicCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteThematic(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ThematicDto>> GetThematicByCourseId(int courseId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateThematic(int id, ThematicUpdateDto thematicUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
