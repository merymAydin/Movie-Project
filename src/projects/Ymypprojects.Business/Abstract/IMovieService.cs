using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using ymypMovieProjectEntity.Dtos.Movies;
using ymypMovieProjectEntity.Entities;

namespace Ymypprojects.Business.Abstract
{
    public interface IMovieService: IGenericService<Movie, MovieResponseDto, MovieAddRequestDto, MovieUpdateRequestDto>, IGenericServiceAsync<Movie, MovieResponseDto, MovieAddRequestDto, MovieUpdateRequestDto>
    {
        List<MovieDetailDto> GetMoviesWithFullInfo();
    }
}