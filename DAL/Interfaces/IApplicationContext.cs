using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMyCinema.Models;

namespace NIx_CinemaSite.DAL.Interfaces
{
    public interface IApplicationContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<UserAccount> UserAccounts {get;set;}
    }
}
