using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace ymypMovieProjectEntity.Dtos.Directors;
public sealed record DirectorsResponseDto(
        Guid id,
        string FirstName,
        string LastName,
        string ImageUrl,
        DateTime BirthDate,
        string Description
        ) : IResponseDto;
