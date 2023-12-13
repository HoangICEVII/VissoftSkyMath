using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.Application.Services.AdminService
{
    public class AdminThematicService : IAdminThematicService
    {
        private readonly IThematicRepository _thematicRepository;
        public AdminThematicService(IThematicRepository thematicRepository)
        {
            _thematicRepository = thematicRepository;
        }
        public async Task CreateThematic(ThematicCreateDto thematicCreateDto)
        {
            await _thematicRepository.CreateThematic(thematicCreateDto);
        }

        public async Task DeleteThematic(int id)
        {
            await _thematicRepository.DeleteThematic(id);
        }

        public async Task UpdateThematic(int id, ThematicUpdateDto thematicUpdateDto)
        {
            await _thematicRepository.UpdateThematic(id, thematicUpdateDto);
        }
    }
}
