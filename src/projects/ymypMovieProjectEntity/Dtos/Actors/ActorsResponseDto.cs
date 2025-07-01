using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;
using ymypMovieProjectEntity.Entities;

namespace ymypMovieProjectEntity.Dtos.Actors
{
    public sealed record ActorsResponseDto(
        Guid Id,
        string Firstname, 
        string LastName,
        string? imageUrl,
        DateTime? BirthDate,
        string Description,
        bool isActive = true
        ) :IResponseDto;
}