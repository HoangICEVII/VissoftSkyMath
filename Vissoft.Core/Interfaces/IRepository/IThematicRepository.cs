using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;

namespace Vissoft.Core.Interfaces.IRepository
{
    public interface IThematicRepository
    {
        Task<List<ThematicDto>> GetThematic();
        Task AddNewThematic(ThematicCreateDto thematicCreateDto);
        Task UpdateThematic(ThematicUpdateDto thematicUpdateDto);
        Task DeleteThematic(int thematicId);
    }
}
