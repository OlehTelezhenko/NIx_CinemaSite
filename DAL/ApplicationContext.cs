using Microsoft.EntityFrameworkCore;
using NIx_CinemaSite.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMyCinema.Models;

namespace NIx_CinemaSite.DAL
{
    public class ApplicationContext : IApplicationContext
    {
        public ApplicationContext()
        {

        }

        public DbSet<Cinema> Cinemas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Film> Films { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Actor> Actors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Genre> Genres { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<UserAccount> UserAccounts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
