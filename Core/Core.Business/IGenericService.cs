using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business.Utilities.Result;
using Core.Entity;
using ymypMovieProjectEntity.Dtos.Categories;

namespace Core.Business
{
    public interface IGenericService<TEntity,TResponseDto,TCreateDto,TUpdateDto> 
        where TEntity : class,IEntity, new()
        where TResponseDto : class, IResponseDto
        where TCreateDto : class, ICreateDto
        where TUpdateDto : class, IUpdateDto
    {
        IResult Insert(TCreateDto dto);
        IResult Modify(TUpdateDto dto);
        IResult Remove (Guid id);
        ICollection<TResponseDto> GetAll();
        TResponseDto GetById(Guid id);
        IResult Modify(CategoryUpdateRequestDto dto);
    }
}