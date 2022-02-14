using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_CinemaSite.DAL.Interfaces
{
    public interface IUnitOfWork<TDBContext> where TDBContext : DbContext
    {

    }
}
