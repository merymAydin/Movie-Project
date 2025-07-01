using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;

namespace ymypMovieProject.WebAPI.Controllers;
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IDirectorService _directorService;

    public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

    [HttpGet]
        public IActionResult GetAll()
        {
            var movies = _movieService.GetAll();
            return Ok(movies);
        }
        [HttpGet("FullInfo")]
        public IActionResult GetAllFullInfo()
        {
            var movies = _movieService.GetByMovieWithFullInfo();
            var dto = movies.Select(m=>new
            {
                m.Id,
                m.Name,
                m.Description,
                m.IMDB,
                Category = new
                {
                    m.Category.Name
                },
                Director = new
                {
                    m.Director.FirstName,
                    m.Director.LastName,
                    m.Director.imageUrl
                }
            }).ToList();
            return Ok(dto);
        }

        [HttpGet("{id}")]
        public IActionResult GetDirector(string id)
        {
             Director director = _directorService.GetById(Guid.Parse(id));
             return Ok(director);
        }
    }                                             