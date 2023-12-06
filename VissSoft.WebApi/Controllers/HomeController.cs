using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using VissSoft.Core.Interfaces.IServices;

namespace VissSoft.WebApi.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : BaseController
    {
        private readonly IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet("readAllCourse")]
        public async Task<IActionResult> ReadAllCourse()
        {
            try
            {
                var data = await _homeService.readAllCourse();
                if (data == null)
                {
                    return CustomResult("Không tìm thấy dữ liệu!", HttpStatusCode.NotFound);
                }
                return CustomResult("Dữ liệu tải thành công!", data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("readByCourseId/{id}")]
        public async Task<IActionResult> ReadByCourseId(int id)
        {
            try
            {
                var data = await _homeService.readByCourseId(id);
                if (data == null)
                {
                    return CustomResult("Không tìm thấy dữ liệu!", HttpStatusCode.NotFound);
                }
                return CustomResult("Dữ liệu tải thành công!", data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("readAllIntro")]
        public async Task<IActionResult> ReadAllIntro()
        {
            try
            {
                var data = await _homeService.readAllIntro();
                if (data == null)
                {
                    return CustomResult("Không tìm thấy dữ liệu!", HttpStatusCode.NotFound);
                }
                return CustomResult("Dữ liệu tải thành công!", data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("readByIntroId/{id}")]
        public async Task<IActionResult> ReadByIntroId(int id)
        {
            try
            {
                var data = await _homeService.readByIntroId(id);
                if (data == null)
                {
                    return CustomResult("Không tìm thấy dữ liệu!", HttpStatusCode.NotFound);
                }
                return CustomResult("Dữ liệu tải thành công!", data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("readAllNewAndEvent")]
        public async Task<IActionResult> ReadAllNewAndEvent()
        {
            try
            {
                var data = await _homeService.readAllNewAndEvent();
                if (data == null)
                {
                    return CustomResult("Không tìm thấy dữ liệu!", HttpStatusCode.NotFound);
                }
                return CustomResult("Dữ liệu tải thành công!", data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("readByNewAndEventId/{id}")]
        public async Task<IActionResult> ReadByNewAndEventId(int id)
        {
            try
            {
                var data = await _homeService.readByNewAndEventId(id);
                if (data == null)
                {
                    return CustomResult("Không tìm thấy dữ liệu!", HttpStatusCode.NotFound);
                }
                return CustomResult("Dữ liệu tải thành công!", data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("readAllSlide")]
        public async Task<IActionResult> ReadAllSlide()
        {
            try
            {
                var data = await _homeService.readAllSlide();
                if (data == null)
                {
                    return CustomResult("Không tìm thấy dữ liệu!", HttpStatusCode.NotFound);
                }
                return CustomResult("Dữ liệu tải thành công!", data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("readBySlideId/{id}")]
        public async Task<IActionResult> ReadBySlideId(int id)
        {
            try
            {
                var data = await _homeService.readBySlideId(id);
                if (data == null)
                {
                    return CustomResult("Không tìm thấy dữ liệu!", HttpStatusCode.NotFound);
                }
                return CustomResult("Dữ liệu tải thành công!", data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("readAllTeacher")]
        public async Task<IActionResult> ReadAllTeacher()
        {
            try
            {
                var data = await _homeService.readAllTeacher();
                if (data == null)
                {
                    return CustomResult("Không tìm thấy dữ liệu!", HttpStatusCode.NotFound);
                }
                return CustomResult("Dữ liệu tải thành công!", data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("readByTeacherId/{id}")]
        public async Task<IActionResult> ReadByTeacherId(int id)
        {
            try
            {
                var data = await _homeService.readByTeacherId(id);
                if (data == null)
                {
                    return CustomResult("Không tìm thấy dữ liệu!", HttpStatusCode.NotFound);
                }
                return CustomResult("Dữ liệu tải thành công!", data);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
