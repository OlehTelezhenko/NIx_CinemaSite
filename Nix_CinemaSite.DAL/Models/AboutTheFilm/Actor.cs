using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

//Таблица актеров/режиссеров

namespace Nix_CinemaSite.DAL.Models.AboutTheFilm
{
    public class Actor
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(10), MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(10), MinLength(2)]
        public string LastName { get; set; }

        [MaxLength(2000)]
        public string Biography { get; set; } //краткая био

        public ICollection<Film> FilmsWithTheActor { get; set; } = new List<Film>();

        [Url]
        public string PhotoOfTheActor { get; set; } //фотография 
    }
}
