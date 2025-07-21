using System.IO;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ymypMovieProjectEntity.Dtos.Directors;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;


namespace ymypMovieProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorService _directorService;
        private readonly IMapper _mapper;
        //bu katmana koyarak diğer tüm katmanlara koymaktan kurtuldum
        public DirectorsController(IDirectorService directorService,IMapper mapper)
        {
            _directorService = directorService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _directorService.GetAll(false);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("[action]")]
        public IActionResult GetAllDeleted()
        {
            var result = _directorService.GetAll(true);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("FullInfo")]
        public IActionResult GetAllFullInfo()
        {
            var result = _directorService.GetAllFullInfo();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data); 
        }

        [HttpGet("{id}")]
        public IActionResult GetDirector(Guid id)
        {
            var result = _directorService.GetById(id);
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("GetAllIsActive")]
        public IActionResult GetAllIsActive()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateDirector(DirectorsAddRequestDto dto)
        {
            var result = _directorService.Insert(dto); 
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
        [HttpPut]
        public IActionResult UpdateDirector(DirectorsUpdateRequestDto dto) 
        {
            var result = _directorService.Modify(dto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return Ok(result.Message);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDirector(Guid id)
        {
            var result = _directorService.Remove(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
    }
}