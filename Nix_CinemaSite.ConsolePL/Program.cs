using Nix_CinemaSite.DAL;
using Nix_CinemaSite.DAL.Models.AboutTheFilm;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Nix_CinemaSite.BL;

namespace Nix_CinemaSite.PlConsole
{
    class Program
    {
        public static List<Actor> _Actors = new List<Actor>()
        {
            new Actor()
                {
                    FirstName = "Антон",
                    LastName = "Слепыш",
                    Biography = "Существует",
                    PhotoOfTheActor = "рут/картинки/фотоактера.пнг",
                },
            new Actor()
                {
                    FirstName = "Вова",
                    LastName = "Корова",
                    Biography = "Жил был",
                    PhotoOfTheActor = "рут/картинки/фотоактера.пнг",
                },
            new Actor()
                {
                    FirstName = "Петя",
                    LastName = "Давидоф",
                    Biography = "Царь",
                    PhotoOfTheActor = "рут/картинки/фотоактера.пнг",
                }
        };
        public static List<Director> _Directors = new List<Director>()
        {
            new Director()
                {
                    FirstName = "Петя",
                    LastName = "Давидоф",
                    Biography = "Царь",
                    PhotoOfTheActor = "рут/картинки/фотоактера.пнг",
                }
        };
        public static List<Film> _Films = new List<Film>()
        {
            new Film()
                {
                    Title = "Киборг убийца",
                    Cauntry = "Неизвестная",
                    Rating = 1.4,
                    ReleaseDate = new DateTime(2022, 1, 1),
                    Description = "Киборг уничтожает все что видит",
                    MoviePoster = "рут/картинки/постер.пнг",
                    MovieTrailer = "рут/трейлер/трейлер.ави",
                    ComingSoon = false,
                    Premiere = true,
                    OnlineView = false
                },
            new Film()
                {
                    Title = "Убийца киборга",
                    Cauntry = "Неизвестная",
                    Rating = 1.4,
                    ReleaseDate = new DateTime(2022, 1, 1),
                    Description = "Уничтожит киборка как только увидит",
                    MoviePoster = "рут/картинки/постер.пнг",
                    MovieTrailer = "рут/трейлер/трейлер.ави",
                    ComingSoon = false,
                    Premiere = true,
                    OnlineView = false
                }
        };
        public static List<Genre> _Genres = new List<Genre>()
        {
            new Genre() { GenreName = "Боевик" },
            new Genre() { GenreName = "Для детей" },
            new Genre() { GenreName = "Катастрофы" },
            new Genre() { GenreName = "Комедии" },
            new Genre() { GenreName = "Криминал" }
        };

        static void Main(string[] args)
        {
            ApplicationContext applicationContext = new();
            LoggerFactory logger = new();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();

            UnitOfWork unit = new UnitOfWork(applicationContext, logger);
        }
    }
}

/*
                CyborgKiller.Actors.AddRange(new List<Actors>() { Anton, Vovan, Petya });
                CyborgAntiKiller.Actors.AddRange(new List<Actors>() { Petya, Vovan });
                Anton.FilmsWithTheActor.Add(CyborgKiller);
                Vovan.FilmsWithTheActor.AddRange(new List<Film>() { CyborgKiller, CyborgAntiKiller });
                Petya.FilmsWithTheActor.AddRange(new List<Film>() { CyborgKiller, CyborgAntiKiller });
                db.SaveChanges();

                var films = db.Films.Include(a => a.Actors).ToList();
                foreach (var film in films)
                {
                    Console.WriteLine($"{film.Title}");
                    foreach (Actors f in film.Actors)
                    {
                        Console.WriteLine($"{f.FirstName} {f.LastName}");
                    }
                }
                Console.WriteLine("--------------");
                var actors = db.Actors.Include(f => f.FilmsWithTheActor).ToList();
                foreach (var actor in actors)
                {
                    Console.WriteLine($"{actor.FirstName} {actor.LastName}");
                    foreach (Film a in actor.FilmsWithTheActor)
                    {
                        Console.WriteLine($"{a.Title}");
                    }
                }
                */