using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Business.Utilities.Result;
using Microsoft.EntityFrameworkCore;
using ymypMovieProject.DataAccess.Repositories.Abstract;
using ymypMovieProject.DataAccess.Repositories.Concrete;
using ymypMovieProjectEntity.Dtos.Categories;
using ymypMovieProjectEntity.Dtos.Directors;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;
using Ymypprojects.Business.Constants;

namespace Ymypprojects.Business.Concrete
{
    public sealed class DirectorManager : IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;
        private readonly IMapper _mapper;

        public DirectorManager(IDirectorRepository directorRepository, IMapper mapper)
        {
            _directorRepository = directorRepository;
            _mapper = mapper;
        }

        public IDataResult<ICollection<DirectorsResponseDto>> GetAll()
        {
            try
            {
                var directors = _directorRepository.GetAll(d=> !d.IsDeleted);
                if (directors == null || !directors.Any())
                {
                    return new ErrorDataResult<ICollection<DirectorsResponseDto>>(ResultMessages.ErrorListed);
                }
                var dtos = _mapper.Map<DirectorsResponseDto>(directors);
                return new SuccessDataResult<ICollection<DirectorsResponseDto>>(dtos, ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<ICollection<DirectorsResponseDto>>($"An error occured while retrieving directors : {e.Message}");
            }
        }

        public Task<ICollection<DirectorsResponseDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DirectorsResponseDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<DirectorsResponseDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IResult Insert(DirectorsAddRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(DirectorsAddRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public IResult Modify(DirectorsUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public IResult Modify(CategoryUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public IResult Remove(Guid id)
        {
            throw new NotImplementedException();
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
