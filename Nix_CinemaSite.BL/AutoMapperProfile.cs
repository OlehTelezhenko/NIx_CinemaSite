using AutoMapper;
using Nix_CinemaSite.BL.DataTransferObject.AboutTheFilm;
using Nix_CinemaSite.BL.DataTransferObject.Cinema;
using Nix_CinemaSite.DAL.Models.AboutTheFilm;
using Nix_CinemaSite.DAL.Models.Cinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_CinemaSite.BL
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Actor, ActorsDTO>();
            CreateMap<Film, FilmDTO>();
            CreateMap<Genre, GenreDTO>();
            CreateMap<Cinema, CinemaDTO>();
        }
    }
}
