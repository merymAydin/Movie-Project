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
            var directors = _directorService.GetAllFullInfo();
            //var dto = directors.Select(d=>new 
            //{
            //    ID = d.Id,
            //    Adi = d.FirstName,
            //    Soyadi=d.LastName,
            //    Resim = d.imageUrl,
            //    DogumTarihi = d.BirthDate,
            //    Aciklama=d.Description,
            //    Filmleri = d.Movies.Select(m => new 
            //    {
            //       Film = m.Name,
            //       Kategori= m.Category.Name
            //    }).ToList()
            //}).ToList();
            var dto = directors.Select(d => new
            {
                 d.Id,
                d.FirstName,
                 d.LastName,
                d.imageUrl,
                d.BirthDate,
                d.Description,
                Movies=d.Movies.Select(m => new
                {
                    m.Name,
                    Category = m.Category.Name
                }).ToList()
            }).ToList();
            return Ok(dto);
        }
    }
}