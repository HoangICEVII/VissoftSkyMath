using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;

namespace Vissoft.Infrastructure.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>().HasData(
                new Grade {
                    Id = 1,
                    Name = "Lớp 1",
                },
                new Grade {
                    Id = 2,
                    Name = "Lớp 2",
                },
                new Grade {
                    Id = 3,
                    Name = "Lớp 3",
                },
                new Grade {
                    Id = 4,
                    Name = "Lớp 4",
                },
                new Grade {
                    Id = 5,
                    Name = "Lớp 5",
                },
                new Grade {
                    Id = 6,
                    Name = "Lớp 6",
                },
                new Grade {
                    Id = 7,
                    Name = "Lớp 7",
                },
                new Grade {
                    Id = 8,
                    Name = "Lớp 8",
                },
                new Grade {
                    Id = 9,
                    Name = "Lớp 9",
                },
                new Grade {
                    Id = 10,
                    Name = "Lớp 10",
                },
                new Grade {
                    Id = 11,
                    Name = "Lớp 11",
                },
                new Grade {
                    Id = 12,
                    Name = "Lớp 12",
                }
            );
            modelBuilder.Entity<Subject>().HasData(
                new Subject { 
                    Id = 1, 
                    Name = "Toán",
                    CreatedDate = DateTime.Now,
                    Status = true
                }
            );
            modelBuilder.Entity<Curriculum>().HasData(
                new Curriculum { 
                    Id = 1,
                    Name = "Kết nối tri thức với cuộc sống",
                    CreatedDate = DateTime.Now,
                    Status = true
                },
                new Curriculum {
                    Id = 2,
                    Name = "Cánh diều",
                    CreatedDate = DateTime.Now,
                    Status = true
                },
                new Curriculum {
                    Id = 3,
                    Name = "Chân trường sáng tạo",
                    CreatedDate = DateTime.Now,
                    Status = true
                }
            );
            modelBuilder.Entity<Introduce>().HasData(
                new Introduce {
                    Id = 1,
                    Title = "Toán học SkyMath",
                    Content = "Tại lớp học, các thầy cô luôn có những phương pháp giảng dạy để truyền ngọn lửa đam mê môn học cho các con, giúp khơi gợi niềm say mê học tập.",
                    Status = true
                }
            );

            modelBuilder.Entity<NewsAndEvent>().HasData(
                new NewsAndEvent {
                    Id = 1,
                    ImageLink = "Images/NewAndEvent/news-1.png",
                    Title = "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh",
                    Overview = "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây",
                    Content = "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây",
                    CreatedDate = DateTime.Now,
                    Status = true,
                    
                },
                new NewsAndEvent {
                    Id = 2,
                    ImageLink = "Images/NewAndEvent/news-2.png",
                    Title = "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh",
                    Overview = "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây",
                    Content = "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây",
                    CreatedDate = DateTime.Now,
                    Status = true,
                },
                new NewsAndEvent {
                    Id = 3,
                    ImageLink = "Images/NewAndEvent/news-3.png",
                    Title = "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh",
                    Overview = "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây",
                    Content = "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây",
                    CreatedDate = DateTime.Now,
                    Status = true,
                },
                new NewsAndEvent {
                    Id = 4,
                    ImageLink = "Images/NewAndEvent/news-4.png",
                    Title = "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh",
                    Overview = "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây",
                    Content = "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây",
                    CreatedDate = DateTime.Now,
                    Status = true,
                }
            );

            modelBuilder.Entity<Slide>().HasData(
                new Slide {
                    Id = 1,
                    ImageLink = "Images/Slide/heroes-1.png",
                    Slogan = "Cùng SkyMath bứt phá Điểm 10 không khó",
                    Status = true
                },
                new Slide {
                    Id = 2,
                    ImageLink = "Images/Slide/heroes-2.png",
                    Slogan = "Cùng SkyMath bứt phá Điểm 10 không khó",
                    Status = true
                },
                new Slide {
                    Id = 3,
                    ImageLink = "Images/Slide/heroes-3.png",
                    Slogan = "Cùng SkyMath bứt phá Điểm 10 không khó",
                    Status = true
                }
            );
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher {
                    Id = 1,
                    Name = "Thầy Nguyễn Duy Minh",
                    Avatar = "Images/Teacher/teacher-1.png",
                    WorkPlace = "Trường Tiểu học Lê Văn Tám",
                    Description = "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn..."
                },
                new Teacher {
                    Id = 2,
                    Name = "Cô Hoàng Thị Cẩm Tú",
                    Avatar = "Images/Teacher/teacher-2.png",
                    WorkPlace = "Trường Tiểu học Lê Văn Tám",
                    Description = "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn..."
                },
                new Teacher {
                    Id = 3,
                    Name = "Cô Lương Thùy Linh",
                    Avatar = "Images/Teacher/teacher-3.png",
                    WorkPlace = "Trường Tiểu học Lê Văn Tám",
                    Description = "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn..."
                },
                new Teacher {
                    Id = 4,
                    Name = "Cô Trần Mai Phương",
                    Avatar = "Images/Teacher/teacher-4.png",
                    WorkPlace = "Trường Tiểu học Lê Văn Tám",
                    Description = "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn..."
                }
            );
            modelBuilder.Entity<Course>().HasData(
                new Course {
                    Id = 1,
                    Name = "Khai giảng khóa lớp 1",
                    Info = "Khóa lớp 1 bao gồm các bài tập tự luyện kèm lời giải hay cho môn Toán lớp 1 với nhiều dạng bài khác nhau như tính, điền dấu, so sánh số, giải toán có lời văn, toán đố",                   
                    ImgLink = "Images/Course/course-1.png",
                    Color = "#ffb74a",
                    GradeId = 1,
                    SubjectId = 1,
                    CreatedDate = DateTime.Now,
                    Status = true
                },
                new Course {
                    Id = 2,
                    Name = "Khai giảng khóa lớp 2",
                    Info = "Khóa lớp 2 bao gồm các bài tập tự luyện kèm lời giải hay cho môn Toán lớp 2 với nhiều dạng bài khác nhau như tính, điền dấu, so sánh số, giải toán có lời văn, toán đố",
                    ImgLink = "Images/Course/course-2.png",
                    Color = "#00bc51",
                    GradeId = 2,
                    SubjectId = 1,
                    CreatedDate = DateTime.Now,
                    Status = true
                },
                new Course {
                    Id = 3,
                    Name = "Khai giảng khóa lớp 3",
                    Info = "Khóa lớp 3 bao gồm các bài tập tự luyện kèm lời giải hay cho môn Toán lớp 1 với nhiều dạng bài khác nhau như tính, điền dấu, so sánh số, giải toán có lời văn, toán đố",
                    ImgLink = "Images/Course/course-1.png",
                    Color = "#ff9679",
                    GradeId = 3,
                    SubjectId = 1,
                    CreatedDate = DateTime.Now,
                    Status = true
                },
                new Course {
                    Id = 4,
                    Name = "Khai giảng khóa lớp 4",
                    Info = "Khóa lớp 4 bao gồm các bài tập tự luyện kèm lời giải hay cho môn Toán lớp 1 với nhiều dạng bài khác nhau như tính, điền dấu, so sánh số, giải toán có lời văn, toán đố",
                    ImgLink = "Images/Course/course-2.png",
                    Color = "#1dc2da",
                    GradeId = 4,
                    SubjectId = 1,
                    CreatedDate = DateTime.Now,
                    Status = true
                }
            );
            modelBuilder.Entity<Thematic>().HasData(
                new Thematic {
                    Id = 1,
                    Name = "Chủ đề 1: Các số từ 0 đến 10",
                    CourseId = 1,
                    CreatedDate = DateTime.Now,
                    Status = true
                },
                new Thematic {
                    Id = 2,
                    Name = "Chủ đề 2: Làm quen với một số hình phẳng",
                    CourseId = 1,
                    CreatedDate = DateTime.Now,
                    Status = true
                },
                new Thematic {
                    Id = 3,
                    Name = "Chủ đề 3: Phép cộng, phép trừ trong phạm vi 10",
                    CourseId = 1,
                    CreatedDate = DateTime.Now,
                    Status = true
                },
                new Thematic {
                    Id = 4,
                    Name = "Chủ đề 4: Làm quen với một số hình khối",
                    CourseId = 1,
                    CreatedDate = DateTime.Now,
                    Status = true
                }
            );
            modelBuilder.Entity<Lesson>().HasData(
                new Lesson {
                    Id = 1,
                    Name = "Các số 0,1,2,3,4,5",
                    ThematicId = 1,
                    CreatedDate = DateTime.Now,
                    Status = true
                },
                new Lesson {
                    Id = 2,
                    Name = "Các số 6,7,8,9,10",
                    ThematicId = 1,
                    CreatedDate = DateTime.Now,
                    Status = true
                },
                new Lesson {
                    Id = 3,
                    Name = "Nhiều hơn, ít hơn, bằng nhau",
                    ThematicId = 1,
                    CreatedDate = DateTime.Now,
                    Status = true
                },
                new Lesson {
                    Id = 4,
                    Name = "So sánh số",
                    ThematicId = 1,
                    CreatedDate = DateTime.Now,
                    Status = true
                }
            );
            modelBuilder.Entity<ResourceType>().HasData(
                new ResourceType {
                    Id = 1,
                    Name = "Text"
                },
                new ResourceType {
                    Id = 2,
                    Name = "Audio"
                },
                new ResourceType {
                    Id = 3,
                    Name = "Video"
                }
            );
            modelBuilder.Entity<Resource>().HasData(
                new Resource {
                    Id = 1,
                    LessonId = 1,
                    ResourceTypeId = 3,
                    Name = "Các số 0,1,2,3,4,5",
                    Link = "https://youtu.be/THQBntZoHaI"
                },
                new Resource {
                    Id = 2,
                    LessonId = 2,
                    ResourceTypeId = 3,
                    Name = "Các số 6,7,8,9,10",
                    Link = "https://youtu.be/zzAdZZ-kgyk"
                },
                new Resource {
                    Id = 3,
                    LessonId = 3,
                    ResourceTypeId = 3,
                    Name = "Nhiều hơn, ít hơn, bằng nhau",
                    Link = "https://youtu.be/eFt1jHGAFYE"
                }
            );
            modelBuilder.Entity<Exercise>().HasData(
                new Exercise {
                    Id = 1,
                    Name = "Nhận biết các số từ 0 đến 5",
                    LessonId = 1
                },
                new Exercise {
                    Id = 2,
                    Name = "Cách viết các số từ 0 đến 5",
                    LessonId = 1
                },
                new Exercise {
                    Id = 3,
                    Name = "Đếm đến 5 (Phần 1)",
                    LessonId = 1
                },
                new Exercise {
                    Id = 4,
                    Name = "Đếm đến 5 (Phần 2)",
                    LessonId = 1
                }
            );
            modelBuilder.Entity<QuizType>().HasData(
                new QuizType {
                    Id = 1,
                    Name = "Fill in blank"
                },
                new QuizType {
                    Id = 2,
                    Name = "Matching"
                },
                new QuizType {
                    Id = 1,
                    Name = "Multiple choice"
                },
                new QuizType {
                    Id = 1,
                    Name = "True false"
                }
            );
        }
    }
}
