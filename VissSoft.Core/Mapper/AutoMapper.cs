using AutoMapper;
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

namespace VissSoft.Core.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper() {
            CreateMap<Course, CourseDTO>();
            CreateMap<Intro, IntroDTO>();
            CreateMap<NewAndEvent, NewAndEventDTO>();
            CreateMap<Slide, SlideDTO>();
            CreateMap<Teacher, TeacherDTO>();
        }
    }
}
