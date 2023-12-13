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
        Task<List<ThematicDto>> GetThematicByCourseId(int courseId);
        Task CreateThematic(ThematicCreateDto thematicCreateDto);
        Task UpdateThematic(int id, ThematicUpdateDto thematicUpdateDto);
        Task DeleteThematic(int id);
    }
}
