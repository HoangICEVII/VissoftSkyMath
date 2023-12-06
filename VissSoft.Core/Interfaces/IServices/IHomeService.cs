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

namespace VissSoft.Core.Interfaces.IServices
{
    public interface IHomeService
    {
        Task<List<CourseDTO>?> readAllCourse();
        Task<CourseDTO?> readByCourseId(int id);
        Task<List<IntroDTO>?> readAllIntro();
        Task<IntroDTO?> readByIntroId(int id);
        Task<List<NewAndEventDTO>?> readAllNewAndEvent();
        Task<NewAndEventDTO?> readByNewAndEventId(int id);
        Task<List<SlideDTO>?> readAllSlide();
        Task<SlideDTO?> readBySlideId(int id);
        Task<List<TeacherDTO>?> readAllTeacher();
        Task<TeacherDTO?> readByTeacherId(int id);

    }
}
