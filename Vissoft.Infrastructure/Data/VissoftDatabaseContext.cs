using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.Entities;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;
using Vissoft.Core.Helper;
using Vissoft.Infrastructure.Extensions;

namespace Vissoft.Infrastructure.Data
{
    public class VissoftDatabaseContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }
        public DbSet<Curriculum> Curriculums { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<FillBlank> FillBlanks { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Introduce> Introduces { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Matching> Matchings { get; set; }
        public DbSet<MultipleChoice> MultipleChoices { get; set; }
        public DbSet<NewsAndEventAttribute> NewsAndEventAttributes { get; set; }
        public DbSet<NewsAndEvent> NewsAndEvents { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizType> QuizTypes { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ResourceType> ResourceTypes { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Thematic> Thematics { get; set; }
        public DbSet<TrueFalse> TrueFalses { get; set; }
        public VissoftDatabaseContext(DbContextOptions<VissoftDatabaseContext> options) : base(options)
        {
            
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var modified = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified ||
                            e.State == EntityState.Added);
            foreach (var item in modified)
            {
                switch (item.State)
                {
                    case EntityState.Modified:
                        if (item.Entity is IDateTracking modifiedEntity)
                            modifiedEntity.LastModifiedDate = DateTime.Now;
                        break;
                    case EntityState.Added:
                        if (item.Entity is IDateTracking addedEntity)
                        {
                            addedEntity.CreatedDate = DateTime.Now;
                            addedEntity.LastModifiedDate = DateTime.Now;
                        }
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
        }
    }
}
