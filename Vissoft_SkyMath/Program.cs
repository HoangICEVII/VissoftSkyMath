using Vissoft_SkyMath.Infrastructure.Data;

namespace Vissoft_SkyMath
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerfactory = scope.ServiceProvider.GetService<ILoggerFactory>();
                try
                {
                    var context = services.GetRequiredService<SkyMathDBContext>();
                    //await context.Database.MigrateAsync();
                    //await StoreContextSeed.SeedAsync(context, loggerfactory);
                    //var userManager = services.GetRequiredService<UserManager<AppUser>>();
                    //var identityContext = services.GetRequiredService<IdentityContext>();
                    //await identityContext.Database.MigrateAsync();
                    //await AppIdentityDbContextSeed.SeedUserData(userManager);
                }
                catch (Exception ex)
                {
                    var loger = loggerfactory.CreateLogger<SkyMathDBContext>();
                    loger.LogError(ex, "Something went wrong during migration");
                }
            }
            host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}



//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
