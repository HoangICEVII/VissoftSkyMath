﻿using AutoMapper;
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
    public class CourseRepository : ICourseRepository
    {
        private readonly VissoftDatabaseContext _dbContext;
        private readonly IMapper _mapper;
        public CourseRepository(VissoftDatabaseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public Task<List<CourseDto>> GetCourse()
        {
            throw new NotImplementedException();
        }
        public async Task<List<CourseDto>> GetCourseByGradeId(int gradeId)
        {
            var data = await _dbContext.Courses.Where(c => c.GradeId == gradeId).ToListAsync();
            List<CourseDto> courseDtos = _mapper.Map<List<Course>, List<CourseDto>>(data);
            return courseDtos;
        }
        public async Task AddNewCourse(CourseCreateDto courseCreateDto)
        {
            var data = _mapper.Map<Course>(courseCreateDto);
            await _dbContext.Courses.AddAsync(data);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateCourse(CourseUpdateDto courseUpdateDto)
        {
            var data = await _dbContext.Courses.Where(c => c.Id == courseUpdateDto.Id).ToListAsync();
            Course course = _mapper.Map<Course>(data);
            if (course != null)
            {
                course.Name =courseUpdateDto.Name;
                course.Description =courseUpdateDto.Description;
                course.Status = courseUpdateDto.Status;
                course.GradeId = courseUpdateDto.GradeId;
            }
            else
            {
                throw new Exception("khoa hoc khong ton tai");
            }
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteCourse(int couseId)
        {
            var data = await _dbContext.Courses.FindAsync(couseId);
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
    }
}
