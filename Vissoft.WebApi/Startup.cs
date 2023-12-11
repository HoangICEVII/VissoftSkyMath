using Microsoft.EntityFrameworkCore;
using Vissoft.Infrastructure.Data;
using Vissoft.Infrastructure.Identity;

namespace Vissoft.WebApi
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices()
        {

        }
        public void Configure(IApplicationBuilder app)
        {
            try
            {
                using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<VissoftDatabaseContext>();
                    dbContext.Database.Migrate();
                }
                using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<IdentityDatabaseContext>();
                    dbContext.Database.Migrate();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
