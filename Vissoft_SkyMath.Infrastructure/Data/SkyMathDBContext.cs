using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft_SkyMath.Core.Entities;

namespace Vissoft_SkyMath.Infrastructure.Data
{
    public class SkyMathDBContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public SkyMathDBContext(DbContextOptions<SkyMathDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
