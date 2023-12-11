using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.Application.Services
{
    internal class ThematicService : IThematicService
    {
        public Task CreateThematic(ThematicCreateDto thematicCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteThematic(int thematicId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ThematicDto>> GetAllThematic()
        {
            throw new NotImplementedException();
        }

        public Task<List<ThematicDto>> GetAllThematicByCourseId(int courseId)
        {
            throw new NotImplementedException();
        }
    }
}
