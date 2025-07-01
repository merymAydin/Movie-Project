using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Entity;
using ymypMovieProjectEntity.Dtos.Categories;
using ymypMovieProjectEntity.Dtos.Directors;
using ymypMovieProjectEntity.Entities;

namespace Ymypprojects.Business.Abstract
{
    public interface IDirectorService : IGenericService<Director,DirectorsResponseDto,DirectorsAddRequestDto,DirectorsUpdateRequestDto>
    {
    }
}