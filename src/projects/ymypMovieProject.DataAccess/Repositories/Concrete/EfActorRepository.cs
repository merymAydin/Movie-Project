using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using ymypMovieProject.DataAccess.Context;
using ymypMovieProject.DataAccess.Repositories.Abstract;
using ymypMovieProjectEntity.Entities;

namespace ymypMovieProject.DataAccess.Repositories.Concrete
{
    public sealed class EfActorRepository : EfGenericRepository<Actor, MovieDbContext>, IActorRepository
    {
        public EfActorRepository(MovieDbContext context) : base(context)
        {
        }
    }
}
