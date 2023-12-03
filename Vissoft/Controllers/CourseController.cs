using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService;

namespace Vissoft.Controllers
{
    [Route("api/courses")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseDataService _courseDataService;
        public CourseController(ICourseDataService courseDataService)
        {
            _courseDataService = courseDataService;
        }
        [HttpGet("get-course-by-grade-id/{id}")]
        public async Task<ActionResult<List<CourseDto>>> GetCourseByGradeId(int id)
        {
            try
            {
                return await _courseDataService.GetCourseByGradeId(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [Authorize(Roles = "User")]
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
        [Authorize(Roles = "User")]
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
        [Authorize(Roles = "User")]
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
