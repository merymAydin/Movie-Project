﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;


namespace ymypMovieProject.WebAPI.Controllers
{
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
        public IActionResult Create(Category category)
        {
            _categoryService.Insert(category);
            return Ok(category);
        }
        [HttpPut]
        public IActionResult Update(Category category)
        {
            _categoryService.Modify(category);
            return Content("Kategori güncelleme işlemi başarılı...");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var category = _categoryService.GetById(id);
            _categoryService.Remove(category);
            return Content("Kategori silme işlemi başarılı...");
        }
        [HttpGet("active")]
        public IActionResult GetActiveCategories()
        {
            var activeCategories = _categoryService.GetByIsActive();
            return Ok(activeCategories);
        }
    }
}