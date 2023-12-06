using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Course;
using VissSoft.Core.DTOs.Intro;
using VissSoft.Core.DTOs.NewAndEvent;
using VissSoft.Core.DTOs.Slide;
using VissSoft.Core.DTOs.Teacher;
using VissSoft.Core.Entities;
using VissSoft.Core.Interfaces.IRepositories;
using VissSoft.Infrastracture.Data;

namespace VissSoft.Infrastracture.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly VissSoftDbContext _dbContext;
        private readonly IMapper _mapper;
        public HomeRepository(VissSoftDbContext dbContext, IMapper mapper) {
            _dbContext = dbContext; 
            _mapper = mapper;
        }

        public async Task<List<CourseDTO>?> readAllCourse()
        {
            try
            {
                List<Course> list = await _dbContext.Courses.ToListAsync();
                if (list == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<List<CourseDTO>>(list);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<List<IntroDTO>?> readAllIntro()
        {
            try
            {
                List<Intro> list = await _dbContext.Intros.ToListAsync();
                if (list == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<List<IntroDTO>>(list);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<List<NewAndEventDTO>?> readAllNewAndEvent()
        {
            try
            {
                List<NewAndEvent> list = await _dbContext.NewAndEvents.ToListAsync();
                if (list == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<List<NewAndEventDTO>>(list);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<List<SlideDTO>?> readAllSlide()
        {
            try
            {
                List<Slide> list = await _dbContext.Slides.ToListAsync();
                if (list == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<List<SlideDTO>>(list);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<List<TeacherDTO>?> readAllTeacher()
        {
            try
            {
                List<Teacher> list = await _dbContext.Teachers.ToListAsync();
                if (list == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<List<TeacherDTO>>(list);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<CourseDTO?> readByCourseId(int id)
        {
            try
            {
                var course = await _dbContext.Courses.FindAsync(id);
                if (course == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<CourseDTO>(course);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<IntroDTO?> readByIntroId(int id)
        {
            try
            {
                var intro = await _dbContext.Intros.FindAsync(id);
                if (intro == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<IntroDTO>(intro);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<NewAndEventDTO?> readByNewAndEventId(int id)
        {
            try
            {
                var newAndEvent = await _dbContext.NewAndEvents.FindAsync(id);
                if (newAndEvent == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<NewAndEventDTO>(newAndEvent);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<SlideDTO?> readBySlideId(int id)
        {
            try
            {
                var slide = await _dbContext.Slides.FindAsync(id);
                if (slide == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<SlideDTO>(slide);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<TeacherDTO?> readByTeacherId(int id)
        {
            try
            {
                var teacher = await _dbContext.Teachers.FindAsync(id);
                if (teacher == null)
                {
                    return null;
                }
                else
                {
                    return _mapper.Map<TeacherDTO>(teacher);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
