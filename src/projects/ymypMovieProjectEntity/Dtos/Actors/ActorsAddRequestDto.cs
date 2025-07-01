using Core.Entity;
using ymypMovieProjectEntity.Entities;

namespace ymypMovieProjectEntity.Dtos.Actors;

    public sealed record ActorsAddRequestDto(
        string FirstName,
        string LastName ,
        string? imageUrl ,
        DateTime? BirthDate,
        string? Description
        ): ICreateDto;
        


