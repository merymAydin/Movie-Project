using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;
using ymypMovieProjectEntity.Dtos.Movies;

namespace ymypMovieProjectEntity.Dtos.Directors;

public sealed record DirectorDetailDto(
     Guid id,
    string FirstName,
    string LastName,
    string ImageUrl,
    DateTime BirthDate,
    string Description,
    ICollection<MovieResponseDto> Movies
    ):IResponseDto;