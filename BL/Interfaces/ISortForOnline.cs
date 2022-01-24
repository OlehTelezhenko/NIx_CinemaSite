using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIx_CinemaSite.BL.Interfaces
{
    internal interface ISortForOnline<T>  where T : class
    {
        IEnumerable<T> SortByGenre(); //Сортировать по жанру
        IEnumerable<T> SortByReleaseYear(); //Сортировать по году релиза
        IEnumerable<T> SortByRating(); //Сортировать по рейтингу
    }
}
