using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.WebApi.Controllers.AdminController
{
    [Route("api/admin/thematics")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminThematicController : ControllerBase
    {
        private readonly IAdminThematicService _adminThematicService;
        public AdminThematicController(IAdminThematicService adminThematicService)
        {
            _adminThematicService = adminThematicService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateThematic([FromBody] ThematicCreateDto thematicCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Du lieu khong hop le");
                await _adminThematicService.CreateThematic(thematicCreateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateThematic(int id,[FromBody] ThematicUpdateDto thematicUpdateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Du lieu khong hop le");
                await _adminThematicService.UpdateThematic(id, thematicUpdateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThematic(int id)
        {
            try
            {
                await _adminThematicService.DeleteThematic(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
