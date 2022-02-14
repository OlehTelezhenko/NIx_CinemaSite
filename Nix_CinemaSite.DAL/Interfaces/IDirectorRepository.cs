using Nix_CinemaSite.DAL.Models.AboutTheFilm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_CinemaSite.DAL.Interfaces
{
    public interface IDirectorRepository : IGenericRepository<Director, Guid>
    {
    }
}
