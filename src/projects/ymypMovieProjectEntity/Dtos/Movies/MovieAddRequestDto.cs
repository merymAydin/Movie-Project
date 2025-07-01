using Core.Entity;

namespace ymypMovieProjectEntity.Dtos.Movies;

public sealed record MovieAddRequestDto : ICreateDto
{
    public string? Name { get; init; }
    public string? Description { get; init; }
    public decimal IMDB { get; init; }
    public DateTime PublishDate { get; init; }
    public string? imageUrl { get; init; }
    public Guid CategoryId{ get; init; }
    public Guid DirectorId { get; init; }
}
