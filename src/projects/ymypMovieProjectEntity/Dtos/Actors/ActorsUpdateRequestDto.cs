using Core.Entity;
using ymypMovieProjectEntity.Entities;

namespace ymypMovieProjectEntity.Dtos.Actors
{
    public sealed record ActorsUpdateRequestDto(
        Guid Id,
        string FirstName,
        string LastName,
        string imageUrl,
        DateTime? BirthDate,
        string Description,
        bool isActive = true,
        bool isDeleted = false
        ) : IUpdateDto;
}
