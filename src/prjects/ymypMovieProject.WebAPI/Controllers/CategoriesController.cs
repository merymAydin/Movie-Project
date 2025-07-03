using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ymypMovieProjectEntity.Dtos.Categories;
using ymypMovieProjectEntity.Dtos.Directors;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;
using Ymypprojects.Business.Mappers.Categories;


namespace ymypMovieProject.WebAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]

    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _categoryService.GetAll();
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var category = _categoryService.GetById(id);
            return Ok(category);
        }
        [HttpPost]
        public IActionResult Create(CategoryAddRequestDto category)
        {
           var result = _categoryService.Insert(category);
           if (!result.Success)
           {
            return BadRequest(result.Message);
           }
            return Ok(result.Message);
        }
        [HttpPut]
        public IActionResult Update(CategoryUpdateRequestDto category)
        {
            _categoryService.Modify(category);
            return Content("Kategori güncelleme işlemi başarılı...");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _categoryService.Remove(id);
            return Content("Kategori silme işlemi başarılı...");
        }
        //[HttpGet("active")]
        //public IActionResult GetActiveCategories()
        //{
        //    return Ok();
        //}
        //[HttpGet("GetAllFullInfo")]
        //public IActionResult GetAllFullInfo()
        //{
        //var categories = _categoryService.GetQueryable().Include(c=>c.Movies).ToList();
        //List<CategoryResponseDto> dtos = new List<CategoryResponseDto>();
        //foreach (var category in categories) 
        //{
        //    dtos.Add(new CategoryResponseDto()
        //    {
        //        Id = category.Id,
        //        Name = category.Name,
        //        Description = category.Description ?? string.Empty,
        //    });
        //}
        //var x = new DirectorsResponseDto(Guid.NewGuid(), "Akın","Cengiz","asdafs",DateTime.Now,"asfgsfgdhezf");
        //var y = new DirectorsResponseDto(Guid.NewGuid(), "Akın", "Cengiz", "asd", DateTime.Now, "asdf")
        //{
            
        //};

        //var dto = _mapper.ConvertToResponseList(categories);
        //return Ok(dto);
        //}
    }