using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService.IAdminService;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.WebApi.Controllers.AdminController
{
    [Route("api/admin/grades")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminGradeController : ControllerBase
    {
        private readonly IAdminGradeService _adminGradeService;
        public AdminGradeController(IAdminGradeService adminGradeService)
        {
            _adminGradeService = adminGradeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllGrade()
        {
            try
            {
                var responseData = await _adminGradeService.GetAllGrade();
                return Ok(responseData);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateGrade([FromForm] GradeCreateDto gradeCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Du lieu khong hop le");
                await _adminGradeService.CreateGrade(gradeCreateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            try
            {
                await _adminGradeService.DeleteGrade(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
