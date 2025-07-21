using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Business.Utilities.Result;
using Core.Entity;
using ymypMovieProjectEntity.Dtos.Categories;
using ymypMovieProjectEntity.Dtos.Directors;
using ymypMovieProjectEntity.Entities;

namespace Ymypprojects.Business.Abstract
{
    public interface IDirectorService : IGenericService<Director, DirectorsResponseDto, DirectorsAddRequestDto, DirectorsUpdateRequestDto>, IGenericServiceAsync<Director, DirectorsResponseDto, DirectorsAddRequestDto, DirectorsUpdateRequestDto>
    {
        //List<Director> GetByFirstName(string firstname);
        //List<Director> GetByLastName(string lastname);
        //Director GetByFullName(string firstname, string lastname);
        IDataResult<List<DirectorDetailDto>> GetAllFullInfo();
        //void Insert(DirectorAddRequestDto dto);
        //void Modify(DirectorUpdateRequestDto dto);
        //void Remove(Guid id);
        //ICollection<DirectorResponseDto> GetAll();
        //DirectorResponseDto GetById(Guid id);
    }
}