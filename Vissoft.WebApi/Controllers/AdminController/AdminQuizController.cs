using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Application.Services.AdminService;
using Vissoft.Core.DTOs.FillBlank;
using Vissoft.Core.DTOs.Matching;
using Vissoft.Core.DTOs.MultipleChoice;
using Vissoft.Core.DTOs.Quiz;
using Vissoft.Core.DTOs.QuizType;
using Vissoft.Core.DTOs.TrueFalse;
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.WebApi.Controllers.AdminController
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class AdminQuizController : ControllerBase
    {
        private readonly IAdminQuizService _adminQuizService;
        public AdminQuizController(IAdminQuizService adminQuizService)
        {
            _adminQuizService = adminQuizService;
        }

        [HttpPost]
        public async Task<IActionResult> PostQuiz(int exerciseId, int quizTypeId, [FromBody] QuizRequest request)
        {
            try
            {
                await _adminQuizService.CreateQuiz(exerciseId,quizTypeId,request.QuizCreateDTO,request.FillBlankCreateDTOs,request.MatchingCreateDTOs,request.MultipleChoiceCreateDTOs,request.TrueFalseCreateDTOs);
                return Ok();
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutQuiz(int id, QuizUpdateDTO obj)
        {
            try
            {
                await _adminQuizService.UpdateQuiz(id, obj);
                return Ok();
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteQuizType(int id)
        {
            try
            {
                await _adminQuizService.DeleteQuiz(id);
                return Ok();
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }
    }
}
