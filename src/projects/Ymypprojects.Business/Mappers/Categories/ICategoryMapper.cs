using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ymypMovieProjectEntity.Dtos.Categories;
using ymypMovieProjectEntity.Entities;

namespace Ymypprojects.Business.Mappers.Categories
{
    public interface ICategoryMapper
    {
         Category ConvertToEntity(CategoryAddRequestDto dto);
         Category ConvertToEntity(CategoryUpdateRequestDto dto);
         CategoryResponseDto ConvertToResponse(Category category);
         List<CategoryResponseDto> ConvertToResponseList(List<Category> categories);
    }
}
