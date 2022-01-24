using AutoMapper;
using NIx_CinemaSite.BL.Data_Transfer_Object.AbautTheFilm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIx_CinemaSite.BL
{
    internal class AutoMapper : Profile
    {
        CreateMap <Actor, ActorDTO>();

    }
}
