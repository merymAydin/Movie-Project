using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Business;
using Core.Business.Utilities.Result;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using ymypMovieProject.DataAccess.Repositories.Abstract;
using ymypMovieProjectEntity.Dtos.Categories;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;
using Ymypprojects.Business.Constants;
using Ymypprojects.Business.Validators;


namespace Ymypprojects.Business.Concrete;

public sealed class CategoryManager : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    private readonly CategoryValidator _categoryValidator;
    private readonly CategoryUpdateValidator _updateValidator;

    public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper, CategoryUpdateValidator updateValidator)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
        _updateValidator = new CategoryUpdateValidator();
        _categoryValidator = new CategoryValidator();
        

        //static metodlar nesne üzerinden değil direkt sınıf üzerinden çağrılır
    }
    public IResult Insert(CategoryAddRequestDto dto)
    {
        try
        {
            ValidationResult result = _categoryValidator.Validate(dto);
            if (!result.IsValid)
            {
                string errorMessages = string.Join(",\n ", result.Errors.Select(e => e.ErrorMessage));
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
    public IResult Modify(CategoryUpdateRequestDto dto)
    {
        try
        {
            ValidationResult result = _updateValidator.Validate(dto);
            if (!result.IsValid)
            {
                //eğer doğrulama başarısızsa, validationException fırlatılır.
                string errormessages = string.Join(",\n",result.Errors.Select(e => e.ErrorMessage));
                return new ErrorResult($"{ResultMessages.ErrorCategoryUpdated},\nHataListesi\n{errormessages}");
            }
            var category = _mapper.Map<Category>(dto);
            category.UpdateAt=DateTime.Now;

            _categoryRepository.Update(category);
            return new SuccessResult(ResultMessages.SuccessCategoryUpdated);
        }
        catch (Exception e)
        {
            return new ErrorResult($"An error occured while updating the category{e.Message}");

        }






        ////Gelen dto mapper ile category nesnesine dönüştürülür.
        //Category category = _mapper.Map<Category>(dto);

        ////Category nesnesinin güncellenme tarihi ayarlanır.
        //category.UpdateAt = DateTime.Now; // Ensure UpdatedDate is set to current time

        ////Category nesnesi veritabanına dataaccess metoduyla güncellenir.
        //_categoryRepository.Update(category);
    }

    public IResult Remove(Guid id)
    {
        try
        {
            var category = _categoryRepository.Get(c => c.Id.Equals(id));
            if(category is null)
            {
                return new ErrorResult(ResultMessages.ErrorCategoryGetById);
            }
            category.IsDeleted = true;
            category.IsActive = false;
            category.UpdateAt = DateTime.Now;
            _categoryRepository.Update(category);
            return new SuccessResult(ResultMessages.SuccessCategoryDeleted);
        }
        catch (Exception e)
        {
            return new ErrorResult($"An error occured while updating the category{e.Message}");
        }











        //// ID ile kategori bulunur.
        //Category category = _categoryRepository.Get(c => c.Id.Equals(id));

        //// Eğer kategori bulunamazsa, KeyNotFoundException fırlatılır.
        //if (category == null)
        //{
        //    throw new KeyNotFoundException($"Category with ID {id} not found.");
        //}

        //// Kategori nesnesi soft delete mantığıyla işaretlenir.
        //category.IsDeleted = true; // Soft delete logic
        //category.IsActive = false; // Optionally set IsActive to false

        //// Güncellenme tarihi ayarlanır.
        //category.UpdateAt = DateTime.Now; // Ensure UpdatedDate is set to current time

        //// Kategori nesnesi veritabanına dataaccess metoduyla güncellenir.
        //_categoryRepository.Update(category);
    }
    public IDataResult<ICollection<CategoryResponseDto>> GetAll()
    {
        try
        {
            var categories = _categoryRepository.GetAll();
            if(categories is null || !categories.Any())
            {
                return new ErrorDataResult<ICollection<CategoryResponseDto>>(ResultMessages.ErrorCategoryListed);
            }
            //kategoriler, CategoryResponseDTO ya dönüştürülür.
            var categoryDtos = _mapper.Map<ICollection<CategoryResponseDto>>(categories);
            return new SuccessDataResult<ICollection<CategoryResponseDto>>(categoryDtos,ResultMessages.SuccessCategoryListed);
        }
        catch (Exception e)
        {
            return new ErrorDataResult<ICollection<CategoryResponseDto>>($"An error occured while retrieving categories : {e.Message}");
        }
        //// Tüm kategorileri veritabanından alınır.
        //var categories = _categoryRepository.GetQueryable().ToList();

        //// Kategoriler, CategoryResponseDto'ya dönüştürülür.
        //var categoryDtos = _mapper.Map<List<CategoryResponseDto>>(categories);
        //// Kategoriler DTO'ya dönüştürüldükten sonra , DTO listesi döndürülür.
        //return categoryDtos;
    }
    public IDataResult<CategoryResponseDto> GetById(Guid id)
    {
        try
        {
            var category = _categoryRepository.Get(c => c.Id.Equals(id) && ! c.IsDeleted);
            if (category == null)
            {
                return new ErrorDataResult<CategoryResponseDto>(ResultMessages.ErrorCategoryGetById);
            }
            var dto = _mapper.Map<CategoryResponseDto>(category);
            return new SuccessDataResult<CategoryResponseDto>(dto,ResultMessages.SuccessCategoryGetById);
        }
        catch (Exception e)
        {
            return new ErrorDataResult<CategoryResponseDto>($"an error occured while retrieving the category : {e.Message}");
        }



        //ID ile kategori bulunur.
        //var category = _categoryRepository.Get(c=>c.Id.Equals(id));
        //if(category == null)
        //{
        //    throw new KeyNotFoundException($"category with ID {id} not found.");
        //}
        ////kategori categoryResponseDtoya dönüştürülür
        //var categoryDto = _mapper.Map<CategoryResponseDto>(category);
        //return categoryDto;
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
}