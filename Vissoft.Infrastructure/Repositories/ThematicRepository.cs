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
        public Task AddNewThematic(ThematicCreateDto thematicCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteThematic(int thematicId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ThematicDto>> GetThematic()
        {
            throw new NotImplementedException();
        }

        public Task UpdateThematic(ThematicUpdateDto thematicUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
