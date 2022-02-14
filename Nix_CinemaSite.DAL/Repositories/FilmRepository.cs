using Nix_CinemaSite.DAL.GenericRepositories;
using Nix_CinemaSite.DAL.Interfaces;
using Nix_CinemaSite.DAL.Models.AboutTheFilm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_CinemaSite.DAL.Repositories
{
    public class FilmRepository : GenericRepository<Film,Guid> ,IFilmRepository
    {
        public FilmRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
