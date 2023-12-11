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
        public async Task CreateGrade(GradeCreateDto gradeCreateDto)
        {
            var data = _mapper.Map<GradeCreateDto, Grade>(gradeCreateDto);
            await _dbContext.Grades.AddAsync(data);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteGrade(int gradeId)
        {
            var data = await _dbContext.Grades.FindAsync(gradeId);
            if (data != null)
            {
                _dbContext.Grades.Remove(data);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("khoa hoc khong ton tai");
            }
        }
    }
}
