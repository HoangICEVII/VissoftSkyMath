using Microsoft.AspNetCore.Mvc;

namespace Vissoft.Controllers
{
    public class CourseController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
