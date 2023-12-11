using Microsoft.AspNetCore.Mvc;
using Vissoft.Application.Services;
using Vissoft.Core.DTOs;
using Vissoft.Core.DTOs.Thematic;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.WebApi.Controllers.ApplicationController
{
    [Route("api/grades")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IGradeService _gradeService;
        private readonly ICourseService _courseService;
        public GradeController(IGradeService gradeService, ICourseService courseService) {
            _gradeService = gradeService;
            _courseService = courseService;
        }
        [HttpGet]
        public async Task<ActionResult<List<GradeDto>>> GetAllGrade()
        {
            var responseData = await _gradeService.GetAllGrade();
            return Ok(responseData);
        }
        [HttpGet("{id}/courses")]
        public async Task<ActionResult<List<CourseDto>>> GetAllCourseByGradeId(int id)
        {
            try
            {
                var responseData = await _courseService.GetAllCourseByGradeId(id);
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
