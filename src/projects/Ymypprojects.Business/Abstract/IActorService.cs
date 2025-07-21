using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Business.Utilities.Result;
using ymypMovieProjectEntity.Dtos.Actors;
using ymypMovieProjectEntity.Entities;

namespace Ymypprojects.Business.Abstract;
    public interface IActorService : IGenericService<Actor,ActorsResponseDto,ActorsAddRequestDto,ActorsUpdateRequestDto>,
    IGenericServiceAsync<Actor, ActorsResponseDto, ActorsAddRequestDto, ActorsUpdateRequestDto>
    {
     IDataResult <ActorDetailDto> GetActorWithMovies(Guid id);
     IDataResult<ICollection<ActorDetailDto>> GetActorsWithMovies();
    }