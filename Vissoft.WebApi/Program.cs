using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Vissoft;
using Vissoft.Application.Services;
using Vissoft.Core.Entities;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.WebApi.Helpers;
using Vissoft.Infrastructure.Data;
using Vissoft.Infrastructure.Identity;
using Vissoft.Infrastructure.Repositories;
using Vissoft.WebApi;
using Microsoft.Extensions.FileProviders;
using Vissoft.Core.Interfaces.IService.IApplicationService;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<VissoftDatabaseContext>(options =>
            options.UseMySql(connectionString,
            ServerVersion.AutoDetect(connectionString)));
builder.Services.AddDbContext<IdentityDatabaseContext>(options =>
            options.UseMySql(connectionString,
            ServerVersion.AutoDetect(connectionString)));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "VissoftApi", Version = "v1" });

    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter JWT Bearer token",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT"
    };
    c.AddSecurityDefinition("Bearer", securityScheme);

    var securityRequirement = new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    };
    c.AddSecurityRequirement(securityRequirement);
});


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidIssuer = builder.Configuration.GetSection("AppSettings:Issuer").Value,
        ValidAudience = builder.Configuration.GetSection("AppSettings:Audience").Value,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value!))
    };
});

//Service Dependency Injection
builder.Services.AddScoped<ICourseService, CourseDataService>();
builder.Services.AddScoped<IUserService, UserService>();

//Repository Dependency Injection
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IGradeRepository, GradeRepository>();
builder.Services.AddScoped<ILessonRepository, LessonRepository>();
builder.Services.AddScoped<IThematicRepository, ThematicRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

//DbContext Denpendency Injection
builder.Services.AddScoped<VissoftDatabaseContext, VissoftDatabaseContext>();
builder.Services.AddScoped<IdentityDatabaseContext, IdentityDatabaseContext>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfiles));
builder.Services.AddCors(option =>
{
    option.AddPolicy(name: "CorsPolicy",
        configurePolicy: builder => builder
        .SetIsOriginAllowed((host) => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());
});

var app = builder.Build();

//app.UseMiddleware<ExceptionMiddle>();
//app.UseStatusCodePagesWithReExecute("/error/{0}");
app.UseSwagger();
app.UseSwaggerUI(option => option.SwaggerEndpoint("/swagger/v1/swagger.json", "VissoftJWToken v1"));

//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider("/app/Images/Course"),
//    RequestPath = "/resource/image/course"
//});

//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider("/app/Images/NewAndEvent"),
//    RequestPath = "/resource/image/news"
//});

//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider("/app/Images/Slide"),
//    RequestPath = "/resource/image/slide"
//});

//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider("/app/Images/Teacher"),
//    RequestPath = "/resource/image/teacher"
//});

app.UseRouting();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.UseCors("CorsPolicy");
app.MapControllers();

var startup = new Startup(builder.Configuration);
startup.Configure(app);

app.Run();
