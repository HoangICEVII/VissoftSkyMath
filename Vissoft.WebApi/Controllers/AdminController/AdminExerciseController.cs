using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Application.Services.AdminService;
using Vissoft.Core.DTOs.Exercise;
using Vissoft.Core.DTOs.QuizType;
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.WebApi.Controllers.AdminController
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class AdminExerciseController : ControllerBase
    {
        private readonly IAdminExerciseService _adminExerciseService;
        public AdminExerciseController(IAdminExerciseService adminExerciseService)
        {
            _adminExerciseService = adminExerciseService;
        }

        [HttpGet("GetAllByLessonId/{lessonId}")]
        public async Task<IActionResult> GetAllQuizType(int lessonId)
        {
            try
            {
                var data = await _adminExerciseService.ReadAllExerciseByLessonId(lessonId);
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
                var data = await _adminExerciseService.ReadById(id);
                return Ok(data);
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostExercise(int lessonId,ExerciseCreateDTO obj)
        {
            try
            {
                await _adminExerciseService.CreateExercise(lessonId,obj);
                return Ok();
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutExercise(int id, ExerciseUpdateDTO obj)
        {
            try
            {
                await _adminExerciseService.UpdateExercise(id, obj);
                return Ok();
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteExercise(int id)
        {
            try
            {
                await _adminExerciseService.DeleteExercise(id);
                return Ok();
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }
    }
}
