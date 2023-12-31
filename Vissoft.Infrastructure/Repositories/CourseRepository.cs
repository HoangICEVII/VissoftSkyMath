﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;
using Vissoft.Core.Entities;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Infrastructure.Data;

namespace Vissoft.Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly VissoftDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public CourseRepository(VissoftDatabaseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<CourseDto>> GetAllCourse()
        {
            var data = await _dbContext.Courses.ToListAsync();
            return _mapper.Map<List<Course>, List<CourseDto>>(data);
        }
        public async Task<List<CourseDto>> GetAllCourseByGradeId(int gradeId)
        {
            var data = await _dbContext.Courses.Where(c => c.GradeId == gradeId).ToListAsync();
            return _mapper.Map<List<Course>, List<CourseDto>>(data);
        }
        public async Task CreateCourse(CourseCreateDto courseCreateDto)
        {
            var data = _mapper.Map<CourseCreateDto ,Course>(courseCreateDto);
            await _dbContext.Courses.AddAsync(data);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateCourse(int id, CourseUpdateDto courseUpdateDto)
        {
            var data = await _dbContext.Courses.Where(c => c.Id == id).FirstOrDefaultAsync();
            if (data != null)
            {
                data.Name =courseUpdateDto.Name;
                data.Description =courseUpdateDto.Description;
                data.Status = courseUpdateDto.Status;
                data.GradeId = courseUpdateDto.GradeId;
            }
            else
            {
                throw new Exception("khoa hoc khong ton tai");
            }
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteCourse(int id)
        {
            var data = await _dbContext.Courses.FindAsync(id);
            if(data != null)
            {
                _dbContext.Courses.Remove(data);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("khoa hoc khong ton tai");
            }
        }
        public async Task<CourseDto> GetCourseById(int id)
        {
            var data = await _dbContext.Courses.Where(c => c.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<Course, CourseDto>(data);
        }
    }
}
