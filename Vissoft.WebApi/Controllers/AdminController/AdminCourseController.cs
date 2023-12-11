using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.WebApi.Controllers.AdminController
{
    [Route("api/admin/courses")]
    [ApiController]
    public class AdminCourseController : ControllerBase
    {
        private readonly ICourseService _courseDataService;
        public AdminCourseController(ICourseService courseDataService)
        {
            _courseDataService = courseDataService;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllCourse()
        {
            return Ok();
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseById(int id)
        {
            return Ok();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromForm] CourseCreateDto courseCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Du lieu khong hop le");
                await _courseDataService.CreateCourse(courseCreateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourse(int id, [FromForm] CourseUpdateDto courseUpdateDto)
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
        [HttpDelete("{id}")]
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
