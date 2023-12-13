using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService.IAdminService;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.WebApi.Controllers.AdminController
{
    [Route("api/admin/courses")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminCourseController : ControllerBase
    {
        private readonly IAdminCourseService _adminCourseService;
        public AdminCourseController(IAdminCourseService adminCourseService)
        {
            _adminCourseService = adminCourseService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCourse()
        {
            try
            {
                var responseData = await _adminCourseService.GetAllCourse();
                return Ok(responseData);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseDetail(int id)
        {
            try
            {
                var responseData = await _adminCourseService.GetCourseDetail(id);
                return Ok(responseData);
            }catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromForm] CourseCreateDto courseCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Du lieu khong hop le");
                await _adminCourseService.CreateCourse(courseCreateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourse(int id, [FromForm] CourseUpdateDto courseUpdateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Du lieu khong hop le");
                await _adminCourseService.UpdateCourse(id, courseUpdateDto);
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
                await _adminCourseService.DeleteCourse(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
