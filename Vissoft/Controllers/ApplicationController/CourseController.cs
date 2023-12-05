using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService;

namespace Vissoft.Controllers.ApplicationController
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
    }
}
