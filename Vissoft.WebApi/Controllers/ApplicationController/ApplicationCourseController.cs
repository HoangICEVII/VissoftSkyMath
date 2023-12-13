using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Vissoft.Core.DTOs;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.WebApi.Controllers.ApplicationController
{
    [Route("api/courses")]
    [ApiController]
    public class ApplicationCourseController : ControllerBase
    {
        private readonly IApplicationCourseService _applicationCourseService;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;
        public ApplicationCourseController(IApplicationCourseService applicationCourseService, IMapper mapper, IMemoryCache memoryCache)
        {
            _applicationCourseService = applicationCourseService;
            _mapper = mapper;
            _memoryCache = memoryCache;
        }
        //[HttpGet]
        //public async Task<ActionResult<List<CourseDto>>> GetAllCourse()
        //{
        //    if(!_memoryCache.TryGetValue("", out List<CourseDto> responseData))
        //    {
        //        responseData = await _courseDataService.GetAllCourseByGradeId();
        //        var cacheEntryOptions = new MemoryCacheEntryOptions()
        //            .SetSlidingExpiration(TimeSpan.FromSeconds(45))
        //            .SetAbsoluteExpiration(TimeSpan.FromSeconds(600))
        //            .SetPriority(CacheItemPriority.Normal);
        //        _memoryCache.Set("", responseData, cacheEntryOptions);
        //    }
        //    return Ok(responseData);
        //}
        [HttpGet("{id}/thematics/lessons")]
        public async Task<ActionResult<List<CourseDto>>> GetCourseDetail(int id)
        {
            try
            {
                var responseData = await _applicationCourseService.GetCourseDetail(id);
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
