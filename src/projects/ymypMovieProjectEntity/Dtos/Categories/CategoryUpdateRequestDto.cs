using Core.Entity;

namespace ymypMovieProjectEntity.Dtos.Categories;

public sealed record CategoryUpdateRequestDto : IUpdateDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public bool isActive { get; init; } = true;
    public bool isdelete { get; init; } = false;
}