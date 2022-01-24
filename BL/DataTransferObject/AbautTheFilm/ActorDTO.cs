using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIx_CinemaSite.BL.Data_Transfer_Object.AbautTheFilm
{
    internal class ActorDTO
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(10), MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(10), MinLength(2)]
        public string LastName { get; set; }

        public string FilmsWithTheActor { get; set; } 

        [Url]
        public string PhotoOfTheActor { get; set; } 
    }
}
