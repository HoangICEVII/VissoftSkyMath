using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vissoft.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataP2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CurriculumId",
                table: "course",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "curriculum",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6709), null, null, "Kết nối tri thức với cuộc sống", true },
                    { 2, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6711), null, null, "Cánh diều", true },
                    { 3, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6713), null, null, "Chân trường sáng tạo", true }
                });

            migrationBuilder.InsertData(
                table: "grade",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Lớp 1" },
                    { 2, "Lớp 2" },
                    { 3, "Lớp 3" },
                    { 4, "Lớp 4" },
                    { 5, "Lớp 5" },
                    { 6, "Lớp 6" },
                    { 7, "Lớp 7" },
                    { 8, "Lớp 8" },
                    { 9, "Lớp 9" },
                    { 10, "Lớp 10" },
                    { 11, "Lớp 11" },
                    { 12, "Lớp 12" }
                });

            migrationBuilder.InsertData(
                table: "introduce",
                columns: new[] { "Id", "Content", "Status", "Title" },
                values: new object[] { 1, "Tại lớp học, các thầy cô luôn có những phương pháp giảng dạy để truyền ngọn lửa đam mê môn học cho các con, giúp khơi gợi niềm say mê học tập.", true, "Toán học SkyMath" });

            migrationBuilder.InsertData(
                table: "newsAndEvent",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "ImageLink", "LastModifiedBy", "LastModifiedDate", "Overview", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây", null, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6760), "Images/NewAndEvent/news-1.png", null, null, "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây", true, "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh" },
                    { 2, "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây", null, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6762), "Images/NewAndEvent/news-2.png", null, null, "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây", true, "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh" },
                    { 3, "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây", null, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6763), "Images/NewAndEvent/news-3.png", null, null, "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây", true, "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh" },
                    { 4, "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây", null, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6764), "Images/NewAndEvent/news-4.png", null, null, "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây", true, "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh" }
                });

            migrationBuilder.InsertData(
                table: "quizType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fill in blank" },
                    { 2, "Matching" },
                    { 3, "Multiple choice" },
                    { 4, "True false" }
                });

            migrationBuilder.InsertData(
                table: "resourceType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Text" },
                    { 2, "Audio" },
                    { 3, "Video" }
                });

            migrationBuilder.InsertData(
                table: "slide",
                columns: new[] { "Id", "ImageLink", "Slogan", "Status" },
                values: new object[,]
                {
                    { 1, "Images/Slide/heroes-1.png", "Cùng SkyMath bứt phá Điểm 10 không khó", true },
                    { 2, "Images/Slide/heroes-2.png", "Cùng SkyMath bứt phá Điểm 10 không khó", true },
                    { 3, "Images/Slide/heroes-3.png", "Cùng SkyMath bứt phá Điểm 10 không khó", true }
                });

            migrationBuilder.InsertData(
                table: "subject",
                columns: new[] { "Id", "CreatedDate", "Description", "LastModifiedDate", "Name", "Status" },
                values: new object[] { 1, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6673), null, null, "Toán", true });

            migrationBuilder.InsertData(
                table: "teacher",
                columns: new[] { "Id", "Avatar", "Description", "Name", "WorkPlace" },
                values: new object[,]
                {
                    { 1, "Images/Teacher/teacher-1.png", "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn...", "Thầy Nguyễn Duy Minh", "Trường Tiểu học Lê Văn Tám" },
                    { 2, "Images/Teacher/teacher-2.png", "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn...", "Cô Hoàng Thị Cẩm Tú", "Trường Tiểu học Lê Văn Tám" },
                    { 3, "Images/Teacher/teacher-3.png", "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn...", "Cô Lương Thùy Linh", "Trường Tiểu học Lê Văn Tám" },
                    { 4, "Images/Teacher/teacher-4.png", "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn...", "Cô Trần Mai Phương", "Trường Tiểu học Lê Văn Tám" }
                });

            migrationBuilder.InsertData(
                table: "course",
                columns: new[] { "Id", "Color", "CreatedBy", "CreatedDate", "CurriculumId", "Description", "GradeId", "ImgLink", "Info", "LastModifiedBy", "LastModifiedDate", "Name", "Status", "SubjectId" },
                values: new object[,]
                {
                    { 1, "#ffb74a", null, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6830), null, null, 1, "Images/Course/course-1.png", "Khóa lớp 1 bao gồm các bài tập tự luyện kèm lời giải hay cho môn Toán lớp 1 với nhiều dạng bài khác nhau như tính, điền dấu, so sánh số, giải toán có lời văn, toán đố", null, null, "Khai giảng khóa lớp 1", true, 1 },
                    { 2, "#00bc51", null, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6833), null, null, 2, "Images/Course/course-2.png", "Khóa lớp 2 bao gồm các bài tập tự luyện kèm lời giải hay cho môn Toán lớp 2 với nhiều dạng bài khác nhau như tính, điền dấu, so sánh số, giải toán có lời văn, toán đố", null, null, "Khai giảng khóa lớp 2", true, 1 },
                    { 3, "#ff9679", null, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6835), null, null, 3, "Images/Course/course-1.png", "Khóa lớp 3 bao gồm các bài tập tự luyện kèm lời giải hay cho môn Toán lớp 1 với nhiều dạng bài khác nhau như tính, điền dấu, so sánh số, giải toán có lời văn, toán đố", null, null, "Khai giảng khóa lớp 3", true, 1 },
                    { 4, "#1dc2da", null, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6837), null, null, 4, "Images/Course/course-2.png", "Khóa lớp 4 bao gồm các bài tập tự luyện kèm lời giải hay cho môn Toán lớp 1 với nhiều dạng bài khác nhau như tính, điền dấu, so sánh số, giải toán có lời văn, toán đố", null, null, "Khai giảng khóa lớp 4", true, 1 }
                });

            migrationBuilder.InsertData(
                table: "thematic",
                columns: new[] { "Id", "CourseId", "CreatedDate", "Description", "LastModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6852), null, null, "Chủ đề 1: Các số từ 0 đến 10", true },
                    { 2, 1, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6854), null, null, "Chủ đề 2: Làm quen với một số hình phẳng", true },
                    { 3, 1, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6855), null, null, "Chủ đề 3: Phép cộng, phép trừ trong phạm vi 10", true },
                    { 4, 1, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6856), null, null, "Chủ đề 4: Làm quen với một số hình khối", true }
                });

            migrationBuilder.InsertData(
                table: "lesson",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "LastModifiedDate", "Name", "Status", "ThematicId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6877), "", null, "Các số 0,1,2,3,4,5", true, 1, null },
                    { 2, null, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6879), "", null, "Các số 6,7,8,9,10", true, 1, null },
                    { 3, null, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6881), "", null, "Nhiều hơn, ít hơn, bằng nhau", true, 1, null },
                    { 4, null, new DateTime(2023, 12, 15, 20, 48, 58, 951, DateTimeKind.Local).AddTicks(6882), "", null, "So sánh số", true, 1, null }
                });

            migrationBuilder.InsertData(
                table: "exercise",
                columns: new[] { "Id", "LessonId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Nhận biết các số từ 0 đến 5" },
                    { 2, 1, "Cách viết các số từ 0 đến 5" },
                    { 3, 1, "Đếm đến 5 (Phần 1)" },
                    { 4, 1, "Đếm đến 5 (Phần 2)" }
                });

            migrationBuilder.InsertData(
                table: "resource",
                columns: new[] { "Id", "LessonId", "Link", "Name", "Rating", "ResourceTypeId", "Time" },
                values: new object[,]
                {
                    { 1, 1, "https://youtu.be/THQBntZoHaI", "Các số 0,1,2,3,4,5", null, 3, null },
                    { 2, 2, "https://youtu.be/zzAdZZ-kgyk", "Các số 6,7,8,9,10", null, 3, null },
                    { 3, 3, "https://youtu.be/eFt1jHGAFYE", "Nhiều hơn, ít hơn, bằng nhau", null, 3, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "course",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "course",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "course",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "curriculum",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "curriculum",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "curriculum",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "exercise",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "exercise",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "exercise",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "exercise",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "grade",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "grade",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "grade",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "grade",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "grade",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "grade",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "grade",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "grade",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "introduce",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "lesson",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "newsAndEvent",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "newsAndEvent",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "newsAndEvent",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "newsAndEvent",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "quizType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "quizType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "quizType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "quizType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "resource",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "resource",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "resource",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "resourceType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "resourceType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "slide",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "slide",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "slide",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "teacher",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "teacher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "teacher",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "teacher",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "thematic",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "thematic",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "thematic",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "grade",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "grade",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "grade",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "lesson",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "lesson",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "lesson",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "resourceType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "thematic",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "course",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "grade",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "subject",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "CurriculumId",
                table: "course",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
