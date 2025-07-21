using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace ymypMovieProjectEntity.Dtos.Users
{
    public sealed record UserForLoginDto(
        string Email,
        string Password
        ) : IResponseDto;
}