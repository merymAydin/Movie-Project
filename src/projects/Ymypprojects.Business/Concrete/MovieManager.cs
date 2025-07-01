using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ymypMovieProject.DataAccess.Repositories.Abstract;
using ymypMovieProject.DataAccess.Repositories.Concrete;
using ymypMovieProjectEntity.Entities;
using Ymypprojects.Business.Abstract;

namespace Ymypprojects.Business.Concrete
{
    public sealed class MovieManager : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieManager(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }
        public Movie GetById(Guid id)
        {
            return _movieRepository.Get(m=>m.Id == id);
        }
        public List<Movie> GetByCategoryId(Guid categoryId)
        {
            return _movieRepository.GetAll(m => m.CategoryId == categoryId).ToList();
        }
        public List<Movie> GetByDirectorId(Guid directorId)
        {
            return _movieRepository.GetAll(m => m.DirectorId == directorId).ToList();
        }
        public List<Movie> GetByGreaterThanIMDB(decimal imdb)
        {
            return _movieRepository.GetAll(m=>m.IMDB >= imdb).ToList();
        }
        public List<Movie> GetByIsActive()
        {
            return _movieRepository.GetAll(m => m.IsActive).ToList();
        }
        public List<Movie> GetByIsDeleted()
        {
            return _movieRepository.GetAll(m => m.IsDeleted);
        }
        public List<Movie> GetByLessThanIMDB(decimal imdb)
        {
            return _movieRepository.GetAll(m=>m.IMDB <= imdb).ToList();
        }
        public List<Movie> GetByName(string name)
        {
            return _movieRepository.GetAll(m=>m.Name.Equals(name)).ToList();
        }
        public IQueryable<Movie> GetQueryable()
        {
            return _movieRepository.GetQueryable();
        }
        public void Insert(Movie entity)
        {
            _movieRepository.Add(entity);
        }
        public void Modify(Movie entity)
        {
            _movieRepository.Update(entity);
        }
        public void Remove(Movie entity)
        {
            entity.IsDeleted = true; // soft delete
            entity.IsActive = false; //deactivate move 
            _movieRepository.Delete(entity);
        }
        public List<Movie> GetByMovieWithFullInfo()
        {
            return _movieRepository.GetQueryable()
                .Include(m=>m.Category)
                .Include(m=>m.Director)
                .Include(m=>m.Actors)
                .ToList();
        }
    }
}