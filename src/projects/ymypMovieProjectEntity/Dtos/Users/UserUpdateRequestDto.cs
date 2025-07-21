using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace ymypMovieProjectEntity.Dtos.Users
{
    public sealed record UserUpdateRequestDto (
        string Firstname,
        string Lastname,
        string Email,
        string Password,
        bool IsActive,
        bool IsDelete
        ) :IUpdateDto;
}
