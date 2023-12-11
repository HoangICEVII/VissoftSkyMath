using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Vissoft.Core.DTOs;
using Vissoft.Core.DTOs.Thematic;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.WebApi.Controllers.ApplicationController
{
    [Route("api/courses")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseDataService;
        private readonly IThematicService _thematicService;
        private readonly ILessonService _lessonService;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;
        public CourseController(ICourseService courseDataService, IThematicService thematicService,ILessonService lessonService, IMapper mapper, IMemoryCache memoryCache)
        {
            _courseDataService = courseDataService;
            _thematicService = thematicService;
            _lessonService = lessonService;
            _mapper = mapper;
            _memoryCache = memoryCache;
        }
        [HttpGet]
        public async Task<ActionResult<List<CourseDto>>> GetAllCourse()
        {
            if(!_memoryCache.TryGetValue("", out List<CourseDto> responseData))
            {
                responseData = await _courseDataService.GetAllCourse();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromSeconds(45))
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(600))
                    .SetPriority(CacheItemPriority.Normal);
                _memoryCache.Set("", responseData, cacheEntryOptions);
            }
            return Ok(responseData);
        }
        [HttpGet("{id}/thematics/lessons")]
        public async Task<ActionResult<List<ThematicDto>>> GetAllThematicAndLessonByCourseId(int id)
        {
            try
            {
                List<ThematicWithLessonDto> responseData = new List<ThematicWithLessonDto>();
                var thematicData = await _thematicService.GetAllThematicByCourseId(id);
                responseData = _mapper.Map<List<ThematicDto>, List<ThematicWithLessonDto>>(thematicData);
                foreach ( var item in responseData )
                {
                    item.LessonDtos = await _lessonService.GetAllLessonByThematicId(item.Id);
                }
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
