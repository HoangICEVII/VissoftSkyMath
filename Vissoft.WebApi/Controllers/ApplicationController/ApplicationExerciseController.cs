using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.WebApi.Controllers.ApplicationController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationExerciseController : ControllerBase
    {
        private readonly IApplicationExerciseService _applicationExerciseService;
        public ApplicationExerciseController(IApplicationExerciseService applicationExerciseService)
        {
            _applicationExerciseService = applicationExerciseService;
        }

        [HttpGet("GetAllByLessonId/{lessonId}")]
        public async Task<IActionResult> GetAllQuizType(int lessonId)
        {
            try
            {
                var data = await _applicationExerciseService.ReadAllExerciseByLessonId(lessonId);
                return Ok(data);
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var data = await _applicationExerciseService.ReadById(id);
                return Ok(data);
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }
    }
}
