using Microsoft.AspNetCore.Mvc;

namespace Vissoft_SkyMath.WebControllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
