using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Infrastructure.Data;

namespace Vissoft.Infrastructure.Repositories
{
    public class GradeRepository : IGradeRepository
    {
        private readonly VissoftDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public GradeRepository(VissoftDatabaseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<GradeDto>> GetGrade()
        {
            var data = await _dbContext.Grades.ToListAsync();
            return _mapper.Map<List<GradeDto>>(data);
        }
        public Task AddNewGrade(GradeCreateDto gradeCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGrade(int gradeId)
        {
            throw new NotImplementedException();
        }
    }
}
