using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.WebApi.Controllers.AdminController
{
    [Route("api/admin/lessons")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminLessonController : ControllerBase
    {
        private readonly IAdminLessonService _adminLessonService;
        public AdminLessonController(IAdminLessonService adminLessonService)
        {
            _adminLessonService = adminLessonService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateLesson([FromBody]LessonCreateDto lessonCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Du lieu khong hop le");
                await _adminLessonService.CreateLesson(lessonCreateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateThematic(int id, [FromBody] LessonUpdateDto lessonUpdateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Du lieu khong hop le");
                await _adminLessonService.UpdateLesson(id, lessonUpdateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLesson(int id)
        {
            try
            {
                await _adminLessonService.DeleteLesson(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
