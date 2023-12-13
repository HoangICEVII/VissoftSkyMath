using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Entities;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Infrastructure.Data;

namespace Vissoft.Infrastructure.Repositories
{
    public class ThematicRepository : IThematicRepository
    {
        private readonly VissoftDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public ThematicRepository(VissoftDatabaseContext dbcontext, IMapper mapper)
        {
            _dbContext = dbcontext;
            _mapper = mapper;
        }
        public async Task CreateThematic(ThematicCreateDto thematicCreateDto)
        {
            var data = _mapper.Map<Thematic>(thematicCreateDto);
            await _dbContext.AddAsync(data);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteThematic(int id)
        {
            var data = await _dbContext.Thematics.FindAsync(id);
            if (data != null)
            {
                _dbContext.Thematics.Remove(data);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("khoa hoc khong ton tai");
            }
        }

        public async Task<List<ThematicDto>> GetThematicByCourseId(int courseId)
        {
            var data = await _dbContext.Thematics.Where(t => t.CourseId == courseId).ToListAsync();
            return _mapper.Map<List<ThematicDto>>(data);
        }

        public async Task UpdateThematic(int id, ThematicUpdateDto thematicUpdateDto)
        {
            var data = await _dbContext.Thematics.Where(t => t.Id == id).FirstOrDefaultAsync();
            if (data != null)
            {
                data.Name = thematicUpdateDto.Name;
            }
            else
            {
                throw new Exception("khoa hoc khong ton tai");
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}
