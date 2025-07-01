using System.IO;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;


namespace ymypMovieProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorService _directorService;
        public DirectorsController(IDirectorService directorService)
        {
            _directorService = directorService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var directors = _directorService.GetAll();
            return Ok(directors);
        }
        [HttpGet("FullInfo")]
        public IActionResult GetAllFullInfo()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetDirector(string id)
        {
            
            return Ok();
        }
        [HttpGet("GetAllIsActive")]
        public IActionResult GetAllIsActive()
        {
            return Ok();
        }
    }
}