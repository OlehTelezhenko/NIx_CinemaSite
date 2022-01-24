using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIx_CinemaSite.BL.DataTransferObject.AbautTheFilm
{
    internal class GenreDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string GenreName { get; set; } //Название жанра
    }
}
