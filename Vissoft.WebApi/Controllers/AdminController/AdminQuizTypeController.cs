using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vissoft.Core.DTOs.QuizType;
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IService.IAdminService;

namespace Vissoft.WebApi.Controllers.AdminController
{
    [Route("api/admin/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class AdminQuizTypeController : ControllerBase
    {
        private readonly IAdminQuizTypeService _adminQuizTypeService;
        public AdminQuizTypeController(IAdminQuizTypeService adminQuizTypeService)
        {
            _adminQuizTypeService = adminQuizTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllQuizType()
        {
            try
            {
                var data = await _adminQuizTypeService.ReadAllQuizType();
                return Ok(data);
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuizTypeById(int id)
        {
            try
            {
                var data = await _adminQuizTypeService.ReadQuizTypeById(id);
                return Ok(data);
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostQuizType(QuizTypeCreateDTO obj)
        {
            try
            {
                await _adminQuizTypeService.CreateQuizType(obj);
                return Ok();
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutQuizType(int id, QuizTypeUpdateDTO obj)
        {
            try
            {
                await _adminQuizTypeService.UpdateQuizType(id,obj);
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
                await _adminQuizTypeService.DeleteQuizType(id);
                return Ok();
            }
            catch (CustomException e)
            {

                return new ObjectResult(new { message = e.Message }) { StatusCode = e.StatusCode };
            }
        }
    }
}
