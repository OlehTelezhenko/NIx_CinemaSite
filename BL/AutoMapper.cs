using AutoMapper;
using NIx_CinemaSite.BL.DataTransferObject.AbautTheFilm;
using NIx_CinemaSite.BL.DataTransferObject.Cinema;
using NIx_CinemaSite.DAL.Models.AboutTheFilm;
using NIx_CinemaSite.DAL.Models.Cinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIx_CinemaSite.BL
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Actor, ActorDTO>();
            CreateMap<Film, FilmDTO>();
            CreateMap<Genre, GenreDTO>();
            CreateMap<Cinema, CinemaDTO>();
        }

    }
}
