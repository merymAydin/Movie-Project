using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ymypprojects.Business.Abstract;

namespace ymypMovieProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieService _movieService;

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
    }
}
