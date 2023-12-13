using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.Application.Services.AdminService
{
    internal class AdminThematicService : IAdminThematicService
    {
        public Task CreateThematic(ThematicCreateDto thematicCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteThematic(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateThematic(int id, ThematicUpdateDto thematicUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
