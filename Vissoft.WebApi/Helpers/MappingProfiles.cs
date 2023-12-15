using AutoMapper;
using Vissoft.Core.DTOs;
using Vissoft.Core.DTOs.Exercise;
using Vissoft.Core.DTOs.FillBlank;
using Vissoft.Core.DTOs.Matching;
using Vissoft.Core.DTOs.MultipleChoice;
using Vissoft.Core.DTOs.Quiz;
using Vissoft.Core.DTOs.QuizType;
using Vissoft.Core.DTOs.TrueFalse;
using Vissoft.Core.Entities;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;

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
            CreateMap<QuizType, QuizTypeDTO>();
            CreateMap<Quiz, QuizDTO>();
            CreateMap<Exercise, ExerciseDTO>();
            CreateMap<FillBlank, FillBlankDTO>();
            CreateMap<Matching, MatchingDTO>();
            CreateMap<MultipleChoice, MultipleChoiceDTO>();
            CreateMap<TrueFalse, TrueFalseDTO>();
            CreateMap<Quiz, QuizTotalDTO>();
        }
    }
}
