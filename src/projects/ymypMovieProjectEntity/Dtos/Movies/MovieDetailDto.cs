using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace ymypMovieProjectEntity.Dtos.Movies
{
    public sealed record MovieDetailDto : IResponseDto
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public string? Description { get; init; }
        public decimal IMDB { get; init; }
        public DateTime PublishDate { get; init; }
        public string? imageUrl { get; init; }
        public bool isActive { get; init; }
        public string CategoryName { get; init; } = string.Empty;
        public string? DirectorFirstName { get; init; }
        public string? DirectorLastName { get; init; }
        public HashSet<string> Players { get; init; } = new HashSet<string>();
    }
}