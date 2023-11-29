using Microsoft.AspNetCore.Mvc;

namespace Vissoft_SkyMath.Controllers.ApiControllers
{
    public class CourseController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
