using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.Interfaces.IService;

namespace Vissoft.Controllers.AdminController
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
