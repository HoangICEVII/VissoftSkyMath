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
            CreateMap<FillBlank, FillBlankDTO>().ForMember(x => x.FillBackAnswer, opt => opt.MapFrom(y => y.Answer));
            CreateMap<Matching, MatchingDTO>().ForMember(x => x.MatchingASide, opt => opt.MapFrom(y => y.ASide)).ForMember(x => x.MatchingBSide, opt => opt.MapFrom(y => y.BSide));
            CreateMap<MultipleChoice, MultipleChoiceDTO>().ForMember(x => x.MultipleChoiceOptionA, opt => opt.MapFrom(y => y.OptionA)).ForMember(x => x.MultipleChoiceOptionB, opt => opt.MapFrom(y => y.OptionB))
                .ForMember(x => x.MultipleChoiceOptionC, opt => opt.MapFrom(y => y.OptionC)).ForMember(x => x.MultipleChoiceOptionD, opt => opt.MapFrom(y => y.OptionD)).ForMember(x => x.MultipleChoiceAnswer, opt => opt.MapFrom(y => y.Answer));
            CreateMap<TrueFalse, TrueFalseDTO>().ForMember(x => x.TrueFalseTopic, opt => opt.MapFrom(y => y.Topic)).ForMember(x => x.TrueFalseAnswer, opt => opt.MapFrom(y => y.Answer));
            CreateMap<Quiz, QuizTotalDTO>();
        }
    }
}
