using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Application.Services;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService;

namespace Vissoft.Controllers.AdminController
{
    public class AdminGradeController : ControllerBase
    {
        private readonly IGradeService _gradeService;
        public AdminGradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }
        [Authorize(Roles = "Admin")]
        [HttpPost("add-new-grade")]
        public async Task<IActionResult> AddNewGrade([FromForm] GradeCreateDto gradeCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Du lieu khong hop le");
                await _gradeService.AddNewGrade(gradeCreateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("delete-grade/{id}")]
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
