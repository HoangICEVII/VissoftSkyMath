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
    public class LessonRepository : ILessonRepository
    {
        private readonly VissoftDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public LessonRepository(VissoftDatabaseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task CreateLesson(LessonCreateDto lessonCreateDto)
        {
            var data = _mapper.Map<LessonCreateDto, Lesson>(lessonCreateDto);
            await _dbContext.Lessons.AddAsync(data);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteLesson(int id)
        {
            var data = await _dbContext.Lessons.FindAsync(id);
            if (data != null)
            {
                _dbContext.Lessons.Remove(data);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("bai hoc khong ton tai");
            }
        }

        public async Task<List<LessonDto>> GetLessonByThematicId(int thematicId)
        {
            var data = await _dbContext.Lessons.Where(l => l.ThematicId == thematicId).ToListAsync();
            return _mapper.Map<List<LessonDto>>(data);
        }

        public async Task UpdateLesson(int id, LessonUpdateDto lessonUpdateDto)
        {
            var data = await _dbContext.Lessons.Where(l => l.Id == id).FirstOrDefaultAsync();
            Lesson lesson = _mapper.Map<Lesson>(data);
            if (lesson != null)
            {
                //lesson.Name = lessonUpdateDto.Name;
                //lesson.Description = lessonUpdateDto.Description;
                //lesson.Status = lessonUpdateDto.Status;
            }
            else
            {
                throw new Exception("khoa hoc khong ton tai");
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}
