using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_CinemaSite.BL.DataTransferObject.AboutTheFilm
{
    internal class FilmDTO
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Title { get; set; }
        [Required]
        [StringLength(20)]
        public string Cauntry { get; set; }
        [Required]
        public List<GenreDTO> Genre { get; set; }
        [Required]
        public float Rating { get; set; }
        [Required]
        public DataType ReleaseDate { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public string Director { get; set; }

        public List<ActorsDTO> Actors;

        [Url]
        public string MoviePoster { get; set; }
        [Url]
        public string MovieTrailer { get; set; }
    }
}
