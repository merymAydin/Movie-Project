using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ymypMovieProject.DataAccess.Repositories.Abstract;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;

namespace Ymypprojects.Business.Concrete
{
    public sealed class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public List<Category> GetAll()
        {
            //_categoryRepository.GetQueryable().ToList();
            //_categoryRepository.GetAll();
            //return _categoryRepository.GetAll(c=>c.IsDeleted);
            return _categoryRepository.GetAll();
        }
        public Category GetById(Guid id)
        {
            return _categoryRepository.Get(c=>c.Id==id);
        }
        public List<Category> GetByIsActive()
        {
            return _categoryRepository.GetAll(c=>c.IsActive);
        }
        public List<Category> GetByIsDeleted()
        {
            return _categoryRepository.GetAll(c=>c.IsDeleted);
        }

        public IQueryable<Category> GetQueryable()
        {
            return _categoryRepository.GetQueryable();
        }
        public void Insert(Category entity)
        {
            _categoryRepository.Add(entity);
        }
        public void Modify(Category entity)
        {
            entity.UpdateAt = DateTime.Now;
            _categoryRepository.Update(entity);
        }
        public void Remove(Category entity)
        {
            entity.IsDeleted = true;
            entity.IsActive = false;
            _categoryRepository.Delete(entity);
        }
        
    }
}