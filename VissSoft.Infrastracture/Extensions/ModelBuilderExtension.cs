using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.Entities;

namespace VissSoft.Infrastracture.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    id = 1,
                    name = "Khai giảng khóa lớp 1",
                    imgLink = "http://209.145.62.69:2002/resource/image/course/course-1.png",
                    color = "#ffb74a",
                    created_at = DateTime.Now,
                    status = true
                },
                new Course()
                {
                    id = 2,
                    name = "Khai giảng khóa lớp 2",
                    imgLink = "http://209.145.62.69:2002/resource/image/course/course-2.png",
                    color = "#00bc51",
                    created_at = DateTime.Now,
                    status = true
                },
                new Course()
                {
                    id = 3,
                    name = "Khai giảng khóa lớp 3",
                    imgLink = "http://209.145.62.69:2002/resource/image/course/course-1.png",
                    color = "#ff9679",
                    created_at = DateTime.Now,
                    status = true
                },
                new Course()
                {
                    id = 4,
                    name = "Khai giảng khóa lớp 4",
                    imgLink = "http://209.145.62.69:2002/resource/image/course/course-2.png",
                    color = "#1dc2da",
                    created_at = DateTime.Now,
                    status = true
                }
            );

            modelBuilder.Entity<Intro>().HasData(
                new Intro()
                {
                    id = 1,
                    title = "Toán học SkyMath",
                    content = "Tại lớp học, các thầy cô luôn có những phương pháp giảng dạy để truyền ngọn lửa đam mê môn học cho các con, giúp khơi gợi niềm say mê học tập.",
                    created_at = DateTime.Now,
                    status = true
                }
            );

            modelBuilder.Entity<NewAndEvent>().HasData(
                new NewAndEvent()
                {
                    id = 1,
                    imgLink = "http://209.145.62.69:2002/resource/image/news/news-1.png",
                    title = "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh",
                    content = "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây",
                    created_at = DateTime.Now,
                    status = true
                },
                new NewAndEvent()
                {
                    id = 2,
                    imgLink = "http://209.145.62.69:2002/resource/image/news/news-2.png",
                    title = "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh",
                    content = "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây",
                    created_at = DateTime.Now,
                    status = true
                },
                new NewAndEvent()
                {
                    id = 3,  
                    imgLink = "http://209.145.62.69:2002/resource/image/news/news-3.png",
                    title = "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh",
                    content = "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây",
                    created_at = DateTime.Now,
                    status = true
                },
                new NewAndEvent()
                {
                    id = 4,
                    imgLink = "http://209.145.62.69:2002/resource/image/news/news-4.png",
                    title = "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh",
                    content = "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây",
                    created_at = DateTime.Now,
                    status = true
                }
            );

            modelBuilder.Entity<Slide>().HasData(
                new Slide()
                {
                    id = 1,
                    imgLink = "http://209.145.62.69:2002/resource/image/slide/heroes-1.png",
                    slogan = "Cùng SkyMath bứt phá Điểm 10 không khó",
                    created_at = DateTime.Now,
                    status = true
                },
                new Slide()
                {
                    id = 2,
                    imgLink = "http://209.145.62.69:2002/resource/image/slide/heroes-2.png",
                    slogan = "Cùng SkyMath bứt phá Điểm 10 không khó",
                    created_at = DateTime.Now,
                    status = true
                },
                new Slide()
                {
                    id = 3,
                    imgLink = "http://209.145.62.69:2002/resource/image/slide/heroes-3.png",
                    slogan = "Cùng SkyMath bứt phá Điểm 10 không khó",
                    created_at = DateTime.Now,
                    status = true
                }
            );
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher()
                {
                    id = 1,
                    name = "Thầy Nguyễn Duy Minh",
                    avatar = "http://209.145.62.69:2002/resource/image/teacher/teacher-1.png",
                    description = "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn...",
                    created_at = DateTime.Now,
                    status = true
                },
                new Teacher()
                {
                    id = 2,
                    name = "Cô Hoàng Thị Cẩm Tú",
                    avatar = "http://209.145.62.69:2002/resource/image/teacher/teacher-2.png",
                    description = "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn...",
                    created_at = DateTime.Now,
                    status = true
                },
                new Teacher()
                {
                    id = 3,
                    name = "Cô Lương Thùy Linh",
                    avatar = "http://209.145.62.69:2002/resource/image/teacher/teacher-3.png",
                    description = "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn...",
                    created_at = DateTime.Now,
                    status = true
                },
                new Teacher()
                {
                    id = 4,
                    name = "Cô Trần Mai Phương",
                    avatar = "http://209.145.62.69:2002/resource/image/teacher/teacher-4.png",
                    description = "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn...",
                    created_at = DateTime.Now,  
                    status = true
                }
            );
        }
    }
}
