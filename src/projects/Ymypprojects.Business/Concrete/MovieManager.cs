using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ymypMovieProject.DataAccess.Repositories.Abstract;
using ymypMovieProject.DataAccess.Repositories.Concrete;
using ymypMovieProjectEntity.Dtos.Movies;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;

namespace Ymypprojects.Business.Concrete
{
    public sealed class MovieManager : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;
        public MovieManager(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }
        public ICollection<MovieResponseDto> GetAll()
        {
            var movies = _movieRepository.GetAll(m=> !m.IsDeleted);
            var movieDtos = _mapper.Map<ICollection<MovieResponseDto>>(movies);
            return movieDtos;
        }
        public MovieResponseDto GetById(Guid id)
        {
            var movie = _movieRepository.Get(m=>m.Id.Equals(id));
            if (movie == null)
            {
                throw new KeyNotFoundException($"Movie with ID{id} not found");
            }
            var movieDto = _mapper.Map<MovieResponseDto>(movie);
            return movieDto;
        }

        public List<MovieDetailDto> GetMoviesWithFullInfo()
        {
            var movies = _movieRepository.GetQueryable(m=> !m.IsDeleted)
                .Include(m=>m.Category)
                .Include(m=>m.Director)
                .Include(m=>m.Actors).ToList();

            var movieDetails = _mapper.Map<List<MovieDetailDto>>(movies);
            return movieDetails;
        }

        public void Insert(MovieAddRequestDto dto)
        {
            var movie = _mapper.Map<Movie>(dto);
            _movieRepository.Add(movie);
        }
        public void Modify(MovieUpdateRequestDto dto)
        {
            var movie = _mapper.Map<Movie>(dto);
            _movieRepository.Update(movie);
        }

        public void Remove(Guid id)
        {
           var movie = _movieRepository.Get(m=>m.Id.Equals(id));
            if (movie == null)
            {
                throw new KeyNotFoundException($"Movie with ID{id} not found");
            }
            movie.IsDeleted = true;
            movie.IsActive = false;
            movie.UpdateAt = DateTime.Now;
            _movieRepository.Update(movie);
        }
    }
}