using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIx_CinemaSite.BL.Services.Films
{
    internal interface IEditingMovieInfo
    {
        void AddFilm();//Добавить новый фильм 
        void EditFilmInfo();//Редактировать данные фильма
        void RemoveFilm();//Удалить фильм 
    }
}
