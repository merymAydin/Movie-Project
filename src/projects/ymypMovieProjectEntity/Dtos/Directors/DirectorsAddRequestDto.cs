using Core.Entity;

namespace ymypMovieProjectEntity.Dtos.Directors;

public sealed record DirectorsAddRequestDto(
        string FirstName,
        string LastName,
        string ImageUrl, //IFormFile olarak değiştirilecek
        DateTime BirthDate,
        string Description
    ) : ICreateDto;
