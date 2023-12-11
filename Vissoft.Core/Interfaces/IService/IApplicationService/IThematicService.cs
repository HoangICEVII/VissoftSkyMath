using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;

namespace Vissoft.Core.Interfaces.IService.IApplicationService
{
    public interface IThematicService
    {
        Task<List<ThematicDto>> GetAllThematic();
        Task<List<ThematicDto>> GetAllThematicByCourseId(int courseId);
        Task CreateThematic(ThematicCreateDto thematicCreateDto);
        Task DeleteThematic(int thematicId);
    }
}
