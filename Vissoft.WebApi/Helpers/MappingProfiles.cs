using AutoMapper;
using Vissoft.Core.DTOs;
using Vissoft.Core.Entities;
using Vissoft.Core.Entities.SkyMathEntities;

namespace Vissoft.WebApi.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() {
            #region Grade
            CreateMap<Grade, GradeDto>();
            #endregion
            CreateMap<Course, CourseDto>();
            CreateMap<Thematic, ThematicDto>();
            CreateMap<Lesson, LessonDto>();
        }
    }
}
