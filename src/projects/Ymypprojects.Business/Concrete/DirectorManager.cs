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
    public sealed class DirectorManager : IDirectorService
    {
        private IDirectorRepository _directorRepository;

        public DirectorManager(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        public List<Director> GetAll()
        {
            return _directorRepository.GetAll();
        }

        public List<Director> GetByFirstname(string firstname)
        {
            return _directorRepository.GetAll(d=>d.FirstName==firstname);
        }

        public List<Director> GetByFullName(string firstName, string lastName)
        {
            return _directorRepository.GetAll(d => d.FirstName == firstName && d.LastName == lastName);
        }

        public Director GetById(Guid id)
        {
            return _directorRepository.Get(d=>d.Id==id);
        }

        public List<Director> GetByIsActive()
        {
            return _directorRepository.GetAll(d => d.IsActive);
        }

        public List<Director> GetByIsDeleted()
        {
            return _directorRepository.GetAll(d => d.IsDeleted);
            //return _directorRepository.GetQueryable(d => d.IsDeleted).Include(d=>d.Movies).ToList();
        }

        public List<Director> GetBylastname(string lastname)
        {
            return _directorRepository.GetAll(d=>d.LastName==lastname);
        }

        public List<Director> GetImageUrl(string url)
        {
            return _directorRepository.GetAll(d=>d.imageUrl==url);
        }

        public IQueryable<Director> GetQueryable()
        {
            throw new NotImplementedException();
        }

        public void Insert(Director entity)
        {
            _directorRepository.Add(entity);
        }

        public void Modify(Director entity)
        {
            _directorRepository.Update(entity);
        }

        public void Remove(Director entity)
        {
            _directorRepository.Delete(entity);
        }
        public List<Director> GetAllFullInfo()
        {
            return _directorRepository.GetQueryable()
                .Include(d=>d.Movies).ThenInclude(m=>m.Category).ToList();
        }
    }
}
