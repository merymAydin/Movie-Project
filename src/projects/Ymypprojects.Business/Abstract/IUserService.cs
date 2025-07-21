using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Business.Utilities.Result;
using Core.Entity.Concrete;
using ymypMovieProjectEntity.Dtos.Users;

namespace Ymypprojects.Business.Abstract
{
    public interface IUserService : IGenericService<User,UserResponseDto,UserForRegisterDto,UserUpdateRequestDto>
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
        IResult Add(User user);
    }
}
