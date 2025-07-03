using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ymypMovieProject.DataAccess.Repositories.Abstract;
using ymypMovieProject.DataAccess.Repositories.Concrete;
using ymypMovieProjectEntity.Dtos.Directors;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;

namespace Ymypprojects.Business.Concrete
{
    public sealed class DirectorManager //: IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;
        private readonly IMapper _mapper;

        public DirectorManager(IDirectorRepository directorRepository, IMapper mapper)
        {
            _directorRepository = directorRepository;
            _mapper = mapper;
        }

        public ICollection<DirectorsResponseDto> GetAll()
        {
            var directors = _directorRepository.GetQueryable().ToList();
            if(directors is null)
            {
                return new List<DirectorsResponseDto>();
            }
            List<DirectorsResponseDto> dtos = _mapper.Map<List<DirectorsResponseDto>>(directors);
            return dtos;
        }

        public Task<ICollection<DirectorsResponseDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DirectorsResponseDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public DirectorsResponseDto GetById(Guid id)
        {
            var directors = _directorRepository.Get(d=>d.Id == id);
            if(directors is null)
            {
                throw new KeyNotFoundException("director not found");
            }
            DirectorsResponseDto dto = _mapper.Map<DirectorsResponseDto>(directors);
            return dto;
        }

        public void Insert(DirectorsAddRequestDto dto)
        {
            Director director = _mapper.Map<Director>(dto);
            director.UpdateAt = DateTime.Now;
            _directorRepository.Add(director);
        }

        public Task InsertAsync(DirectorsAddRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public void Modify(DirectorsUpdateRequestDto dto)
        {
            var director = _mapper.Map<Director>(dto);
            director.UpdateAt = DateTime.Now;
            _directorRepository.Update(director);
        }

        public void Remove(Guid id)
        {
            Director director = _directorRepository.Get(d=>d.Id == id);
            director.IsActive = false;
            director.IsDeleted = true;
            director.UpdateAt= DateTime.Now;
            _directorRepository.Update(director);
        }
        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(DirectorsUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
