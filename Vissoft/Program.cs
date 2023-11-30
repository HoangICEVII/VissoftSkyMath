using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Vissoft.Infrastructure.Data;

namespace Vissoft
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
                    var context = services.GetRequiredService<VissoftDbContext>();
                    await context.Database.MigrateAsync();
                }
                catch (Exception ex)
                {
                    var loger = loggerfactory.CreateLogger<VissoftDbContext>();
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