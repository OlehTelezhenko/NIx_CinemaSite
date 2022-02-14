using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_CinemaSite.BL.Intefaces.Film
{
    public interface IEditingMovieInfo
    {
        void AddFilm();//Добавить новый фильм 
        void EditFilmInfo();//Редактировать данные фильма
        void RemoveFilm();//Удалить фильм 
    }
}
