using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Business.Utilities.Result;
using Core.Entity;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ymypMovieProject.DataAccess.Repositories.Abstract;
using ymypMovieProjectEntity.Dtos.Categories;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;
using Ymypprojects.Business.Constants;
using Ymypprojects.Business.FluentValidators;


namespace Ymypprojects.Business.Concrete
{
    public sealed class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        private readonly CategoryValidator _categoryValidator;

        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _categoryValidator = new CategoryValidator();
        }

        
        public void Modify(CategoryUpdateRequestDto dto)
        {
            //Gelen dto mapper ile category nesnesine dönüştürülür.
            Category category = _mapper.Map<Category>(dto);

            //Category nesnesinin güncellenme tarihi ayarlanır.
            category.UpdateAt = DateTime.Now; // Ensure UpdatedDate is set to current time

            //Category nesnesi veritabanına dataaccess metoduyla güncellenir.
            _categoryRepository.Update(category);
        }

        public void Remove(Guid id)
        {
            // ID ile kategori bulunur.
            Category category = _categoryRepository.Get(c => c.Id.Equals(id));

            // Eğer kategori bulunamazsa, KeyNotFoundException fırlatılır.
            if (category == null)
            {
                throw new KeyNotFoundException($"Category with ID {id} not found.");
            }

            // Kategori nesnesi soft delete mantığıyla işaretlenir.
            category.IsDeleted = true; // Soft delete logic
            category.IsActive = false; // Optionally set IsActive to false

            // Güncellenme tarihi ayarlanır.
            category.UpdateAt = DateTime.Now; // Ensure UpdatedDate is set to current time

            // Kategori nesnesi veritabanına dataaccess metoduyla güncellenir.
            _categoryRepository.Update(category);
        }

        public ICollection<CategoryResponseDto> GetAll()
        {
            // Tüm kategorileri veritabanından alınır.
            var categories = _categoryRepository.GetQueryable().ToList();

            // Kategoriler, CategoryResponseDto'ya dönüştürülür.
            var categoryDtos = _mapper.Map<List<CategoryResponseDto>>(categories);
            // Kategoriler DTO'ya dönüştürüldükten sonra , DTO listesi döndürülür.
            return categoryDtos;
        }

        public CategoryResponseDto GetById(Guid id)
        {
            var category = _categoryRepository.Get(c=>c.Id.Equals(id));
            if(category == null)
            {
                throw new KeyNotFoundException($"category with ID {id} not found.");
            }
            //kategori categoryResponseDtoya dönüştürülür
            var categoryDto = _mapper.Map<CategoryResponseDto>(category);
            return categoryDto;
        }

        public async Task InsertAsync(CategoryAddRequestDto dto)
        {
            try
            {
                if (dto == null)
                {
                    throw new ArgumentNullException(nameof(dto), "CategoryAddRequestDto cannot be null");
                }
               
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public async Task UpdateAsync(CategoryUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CategoryResponseDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryResponseDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IResult Insert(CategoryAddRequestDto dto)
        {
            try
            {
                ValidationResult result = _categoryValidator.Validate(dto);
                if(!result.IsValid)
                {
                    string errorMessages = string.Join(",\n ",result.Errors.Select(e=>e.ErrorMessage));
                    return new ErrorResult(errorMessages);
                }
                //eğer doğrulama başarılıysa, Category nesnesine dönüştürülür
                var category = _mapper.Map<Category>(dto);

                _categoryRepository.Add(category);
                return new SuccessResult(ResultMessages.SuccessCategoryCreated);
            }
            catch (Exception e)
            {
                return new ErrorResult($"An error occurred while adding the category :{e.Message}");
            }
        }
    }
}