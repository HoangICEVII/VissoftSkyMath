using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.WebApi.Controllers.AdminController
{
    public class AdminLessonController : Controller
    {
        private readonly ILessonService _lessonService;
        public AdminLessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }
    }
}
