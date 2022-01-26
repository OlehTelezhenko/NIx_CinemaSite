using System;
using System.ComponentModel.DataAnnotations;

namespace NIx_CinemaSite.DAL.Models.AboutTheFilm
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

        public string FilmsWithTheActor { get; set; } //Фильмы в котором снялся актер    ??

        [Url]
        public string PhotoOfTheActor { get; set; } //фотография 
    }
}
