using Microsoft.EntityFrameworkCore;
using NIx_CinemaSite.DAL.Interfaces;
using NIx_CinemaSite.DAL.Models.AboutTheFilm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIx_CinemaSite.DAL
{
    public class ApplicationContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<UserAuthorization> UsersAuthorizations { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}
