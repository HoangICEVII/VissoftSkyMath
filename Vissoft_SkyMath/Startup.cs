using Microsoft.EntityFrameworkCore;
using Vissoft_SkyMath.Extensions;
using Vissoft_SkyMath.Helpers;
using Vissoft_SkyMath.Infrastructure.Data;

namespace Vissoft_SkyMath
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
            services.AddDbContext<SkyMathDBContext>(options =>
            options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddDbContext<IdentityContext>(options =>
            //options.UseSqlite(Configuration.GetConnectionString("DefaultIdentityConnection")));

            //services.AddSingleton<IConnectionMultiplexer>(c =>
            //{
            //    var configuration = ConfigurationOptions.
            //    Parse(Configuration.GetConnectionString("Radis"), true);
            //    return ConnectionMultiplexer.Connect(configuration);
            //});
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddAutoMapper(typeof(MappingProfiles));
            services.AddControllersWithViews();
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
