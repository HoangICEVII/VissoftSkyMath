using Microsoft.EntityFrameworkCore;
using VissSoft.Infrastracture.Data;

namespace VissSoft.WebApi
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
                    var dbContext = scope.ServiceProvider.GetRequiredService<VissSoftDbContext>();
                    dbContext.Database.Migrate();
                }
            }catch (Exception ex)
            {

            }
        }
    }
}
