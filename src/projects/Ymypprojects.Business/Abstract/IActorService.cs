using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using ymypMovieProjectEntity.Dtos.Actors;
using ymypMovieProjectEntity.Entities;

namespace Ymypprojects.Business.Abstract;
    public interface IActorService : IGenericService<Actor,ActorsResponseDto,ActorsAddRequestDto,ActorsUpdateRequestDto>
    {
     
    }