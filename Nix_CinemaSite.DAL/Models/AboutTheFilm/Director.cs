using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_CinemaSite.DAL.Models.AboutTheFilm
{
    public class Director
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

        public ICollection<Film> FilmsDirectedBy { get; set; } = new List<Film>();

        [Url]
        public string PhotoOfTheActor { get; set; } //фотография 
    }
}
