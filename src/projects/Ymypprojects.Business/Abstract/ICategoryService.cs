using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Entity;
using ymypMovieProjectEntity.Dtos.Categories;
using ymypMovieProjectEntity.Entities;

namespace Ymypprojects.Business.Abstract
{
    public interface ICategoryService : IGenericService<Category,CategoryResponseDto,CategoryAddRequestDto, CategoryUpdateRequestDto>
    {

    }   
}