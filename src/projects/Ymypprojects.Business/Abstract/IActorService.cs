using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using ymypMovieProjectEntity.Entities;

namespace Ymypprojects.Business.Abstract;
    public interface IActorService : IGenericService<Actor>
    {
        List<Actor> GetByFirstName(string firstName);
        List<Actor> GetByLastName(string lastName);
        List<Actor> GetByFullName(string firstName, string lastName); 
    }