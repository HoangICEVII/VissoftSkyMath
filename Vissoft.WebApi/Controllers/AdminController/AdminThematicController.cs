using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.WebApi.Controllers.AdminController
{
    public class AdminThematicController : Controller
    {
        private readonly IThematicService _thematicService;
        public AdminThematicController(IThematicService thematicService)
        {
            _thematicService = thematicService;
        }
    }
}
