using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ymypMovieProjectEntity.Dtos.Actors;
using ymypMovieProjectEntity.Dtos.Categories;
using ymypMovieProjectEntity.Dtos.Directors;
using ymypMovieProjectEntity.Dtos.Movies;
using ymypMovieProjectEntity.Entities;

namespace Ymypprojects.Business.Mappers.Profiles
{
    public sealed class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            //Mapping configurations for Category entity and DTOs
            CreateMap<Category, CategoryResponseDto>().ReverseMap();
            CreateMap<CategoryAddRequestDto, Category>();
            CreateMap<CategoryUpdateRequestDto, Category>();
            CreateMap<Category, CategoryDetailDto>(); 

            //Mapping configurations for Director entity and Dtos
            CreateMap<Director, DirectorsResponseDto>();
            CreateMap<DirectorsAddRequestDto, Director>();
            CreateMap<DirectorsUpdateRequestDto, Director>();
            CreateMap<Director, DirectorDetailDto>();
             
            //Mapping configurations for movie entity and DTOs
            CreateMap<Movie, MovieResponseDto >();
            CreateMap<MovieAddRequestDto,Movie>();
            CreateMap< MovieUpdateRequestDto, Movie>();
            CreateMap<Movie, MovieDetailDto>().ForMember(m => m.Players,option => option.MapFrom(m=>m.Actors.Select(a=> $"{a.FirstName}{a.LastName}").ToHashSet()));

            //Mapping configurations for actor entity and DTOs
            CreateMap<Actor, ActorsResponseDto>();
            CreateMap<ActorsAddRequestDto, Actor>();
            CreateMap<ActorsUpdateRequestDto, Actor>();
            CreateMap<ActorDetailDto, Actor>();
        }
    }
}