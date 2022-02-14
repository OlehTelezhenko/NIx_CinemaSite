using Nix_CinemaSite.DAL.Models.Cinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_CinemaSite.DAL.Interfaces
{
    public interface ICinemaRepository : IGenericRepository<Cinema, Guid>
    {
    }
}
