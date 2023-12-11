using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Application.Services;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.WebApi.Controllers.AdminController
{
    [Route("api/admin/grades")]
    [ApiController]
    public class AdminGradeController : ControllerBase
    {
        private readonly IGradeService _gradeService;
        public AdminGradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllGrade()
        {
            return Ok();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateGrade([FromForm] GradeCreateDto gradeCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Du lieu khong hop le");
                await _gradeService.CreateGrade(gradeCreateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            try
            {
                await _gradeService.DeleteGrade(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
