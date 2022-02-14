using Microsoft.Extensions.Logging;
using Nix_CinemaSite.DAL.Interfaces;
using Nix_CinemaSite.DAL.Repositories;
using System;

namespace Nix_CinemaSite.DAL
{
    public class UnitOfWork 
    {
        private readonly ApplicationContext _applicationContext;
        private readonly ILogger logger;
        private bool disposed = false;

        private ActorRepository filmCrewRep;
        private CinemaRepository cinemaRep;
        private FilmRepository filmRep;
        private GenreRepository genreRep;
        private DirectorRepository directorRep;

        public UnitOfWork(ApplicationContext applicationContext, ILoggerFactory loggerFactory)
        {
            _applicationContext = applicationContext;
            logger = loggerFactory.CreateLogger("logs");
        }

        public UnitOfWork(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }


        public int SaveChanges()
        {
            return _applicationContext.SaveChanges();

        }
        
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _applicationContext.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
