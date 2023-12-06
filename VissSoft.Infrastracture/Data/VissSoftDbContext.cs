using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.Entities;
using VissSoft.Core.Helper;
using VissSoft.Infrastracture.Configurations;
using VissSoft.Infrastracture.Extensions;

namespace VissSoft.Infrastracture.Data
{
    public class VissSoftDbContext : DbContext
    {
        public VissSoftDbContext(DbContextOptions<VissSoftDbContext> options) : base(options)
        {

        }
        public DbSet<Intro> Intros { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<NewAndEvent> NewAndEvents { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

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
                        if (item.Entity is BaseEntity modifiedEntity)
                            modifiedEntity.updated_at = DateTime.Now;
                        break;
                    case EntityState.Added:
                        if (item.Entity is BaseEntity addedEntity)
                        {
                            addedEntity.created_at = DateTime.Now;
                            addedEntity.updated_at = DateTime.Now;
                            addedEntity.status = true;
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
