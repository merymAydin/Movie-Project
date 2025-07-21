using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Business.Utilities.Result;
using Core.Business.Utilities.Security.Jwt;
using Core.Entity.Concrete;
using ymypMovieProjectEntity.Dtos.Users;

namespace Ymypprojects.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
