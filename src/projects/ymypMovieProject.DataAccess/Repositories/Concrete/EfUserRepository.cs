using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.Entity.Concrete;
using ymypMovieProject.DataAccess.Context;
using ymypMovieProject.DataAccess.Repositories.Abstract;

namespace ymypMovieProject.DataAccess.Repositories.Concrete
{
    public class EfUserRepository : EfGenericRepository<User, MovieDbContext>, IUserRepository
    {
        public EfUserRepository(MovieDbContext context) : base(context)
        {

        }
        public List<OperationClaim> GetOperationClaims(User user)
        {
            var claims = from OperationClaim in Context.OperationClaims
                         join UserOperationClaim in Context.UserOperationClaims on OperationClaim.Id equals UserOperationClaim.OperationClaimId
                         where UserOperationClaim.UserId == user.Id
                         select new OperationClaim()
                         {
                             Id = OperationClaim.Id,
                             Name = OperationClaim.Name
                         };
             return claims.ToList();
        }
    }
}