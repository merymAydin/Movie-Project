using AutoMapper;
using Core.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ymypMovieProjectEntity.Dtos.Movies;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;

namespace ymypMovieProject.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;
    private readonly IMapper _mapper;
    public MoviesController(IMovieService movieService, IMapper mapper)
    {
        _movieService = movieService;
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        var result = _movieService.GetAll();
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);
    }
    [HttpGet("[action]")]
    public IActionResult GetAllFullInfo() //ödev olarak tamamla
    {
        var result = _movieService.GetMoviesWithFullInfo();
        if (!result.Success)
        {
            return BadRequest(result.Data);
        }
        return Ok(result.Data);
    }
    [HttpGet("{id:guid}")]
    public IActionResult GetById([FromRoute(Name = "id")] Guid id)
    {
        var result = _movieService.GetById(id);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);
    }
    [HttpPost]
    public IActionResult Insert([FromBody] MovieAddRequestDto dto)
    {
        var result = _movieService.Insert(dto);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Message);
    }
    [HttpPut]
    public IActionResult Update([FromBody] MovieUpdateRequestDto dto)
    {
        var result = _movieService.Modify(dto);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Message);
    }
    [HttpDelete("{id:guid}")]
    public IActionResult Delete([FromRoute(Name = "id")] Guid id)
    {
        var result = _movieService.Remove(id);
        if (!result.Success)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Message);
    }
}