using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Vissoft.Extensions;
using Vissoft.Helpers;
using Vissoft.Infrastructure.Data;

namespace Vissoft
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 34));
            services.AddDbContext<VissoftDbContext>(options =>
            options.UseMySql(Configuration.GetConnectionString("default"), serverVersion));
            //options.UseMySql("server=localhost;port=3306;database=vissoft;user=root;password=123456", serverVersion, b => b.MigrationsAssembly("Vissoft.Infrastructure")));

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddAutoMapper(typeof(MappingProfiles));
            services.AddControllers();
            services.AddApplicationServices();
            //services.AddIdentityService(Configuration);
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("*");
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseMiddleware<ExceptionMiddle>();
            //app.UseStatusCodePagesWithReExecute("/error/{0}");
            //app.UseCors("CorsPolicy");
            app.UseHttpsRedirection();
            //app.UseSwaggerGen();
            app.UseRouting();
            app.UseStaticFiles();
            //app.UseAuthentication();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
