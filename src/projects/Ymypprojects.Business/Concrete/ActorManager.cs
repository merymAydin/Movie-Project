using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ymypMovieProject.DataAccess.Repositories.Abstract;
using ymypMovieProjectEntity.Dtos.Actors;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;

namespace Ymypprojects.Business.Concrete
{
    public sealed class ActorManager //: IActorService
    {
        private readonly IActorRepository _actorRepository;
        private readonly IMapper _mapper;
        public ActorManager(IActorRepository actorRepository,IMapper mapper)
        {
            _actorRepository = actorRepository;
            _mapper = mapper;
        }
        public ICollection<ActorsResponseDto> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<ICollection<ActorsResponseDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public Task<ActorsResponseDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public ActorsResponseDto GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(ActorsAddRequestDto dto)
        {
            var actor = _mapper.Map < Actor > (dto);
            _actorRepository.Add(actor);
        }
        public Task InsertAsync(ActorsAddRequestDto dto)
        {
            throw new NotImplementedException();
        }
        public void Modify(ActorsUpdateRequestDto dto)
        {
            var actor = _mapper.Map< Actor > (dto);
            _actorRepository.Update(actor);
        }
        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public Task UpdateAsync(ActorsUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}