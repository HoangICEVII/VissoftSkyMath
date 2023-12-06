using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using VissSoft.Application.Services;
using VissSoft.Core.Interfaces.IRepositories;
using VissSoft.Core.Interfaces.IServices;
using VissSoft.Infrastracture.Data;
using VissSoft.Infrastracture.Repositories;
using VissSoft.WebApi;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<VissSoftDbContext>(options =>
    options.UseMySql(connectionString,
    ServerVersion.AutoDetect(connectionString)));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//Repository Dependency Injection
builder.Services.AddScoped<IHomeRepository, HomeRepository>();
//Service Dependency Injection
builder.Services.AddScoped<IHomeService, HomeService>();
//DbContext Dependency Injection
builder.Services.AddScoped<VissSoftDbContext, VissSoftDbContext>();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider("/app/Images/Course"),
    RequestPath = "/resource/image/course"
});

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider("/app/Images/NewAndEvent"),
    RequestPath = "/resource/image/news"
});

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider("/app/Images/Slide"),
    RequestPath = "/resource/image/slide"
});

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider("/app/Images/Teacher"),
    RequestPath = "/resource/image/teacher"
});

builder.Services.AddCors(option =>
{
    option.AddPolicy(name: "CorsPolicy",
        configurePolicy: builder => builder
        .SetIsOriginAllowed((host) => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());
});

//Path.Combine("Images", "Slide")

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

var startup = new Startup(builder.Configuration);
startup.Configure(app);

app.Run();
