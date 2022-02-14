using Microsoft.EntityFrameworkCore;
using Nix_CinemaSite.DAL.Models.AboutTheFilm;

namespace Nix_CinemaSite.DAL
{
    public class ApplicationContext : DbContext
    {
        private string _connectionPath;

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Director> Directors { get; set; }

        //public DbSet<Cinema> Cinemas { get; set; }
        //public DbSet<UserAuthorization> UsersAuthorizations { get; set; }
        //public DbSet<UserAccount> UserAccounts { get; set; }

        public ApplicationContext()
        {
            _connectionPath = @"Server=(localdb)\\mssqllocaldb;Database=Nix_CinemaSite;Trusted_Connection=True;";
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public ApplicationContext(string connectionPath)
        {
            _connectionPath = connectionPath;
        }
        public ApplicationContext(DbContextOptions options) : base(options) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionPath,
                    x => x.UseNetTopologySuite());
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
