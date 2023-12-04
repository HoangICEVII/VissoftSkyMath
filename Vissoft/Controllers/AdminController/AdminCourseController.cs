using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService;

namespace Vissoft.Controllers.AdminController
{
    [Route("api/admin/courses")]
    [ApiController]
    public class AdminCourseController : ControllerBase
    {
        private readonly ICourseDataService _courseDataService;
        public AdminCourseController(ICourseDataService courseDataService)
        {
            _courseDataService = courseDataService;
        }
        [Authorize(Roles = "Admin")]
        [HttpPost("add-new-course")]
        public async Task<IActionResult> AddNewCourse([FromForm] CourseCreateDto courseCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Du lieu khong hop le");
                await _courseDataService.AddNewCourse(courseCreateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpPost("update-course")]
        public async Task<IActionResult> UpdateCourse([FromForm] CourseUpdateDto courseUpdateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Du lieu khong hop le");
                await _courseDataService.UpdateCourse(courseUpdateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("delete-course/{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            try
            {
                await _courseDataService.DeleteCourse(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
