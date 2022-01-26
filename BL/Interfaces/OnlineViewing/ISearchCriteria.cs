using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIx_CinemaSite.BL.Interfaces
{
    internal interface ISearchCriteria
    {
        void GetFilmsWithoutCriteria(); //дефолт, последнее поступившее
        void GetFilmsByCriteria(); //По одному критерию
        void GetFilmsByCriteria(); //По двум критериям
        void GetFilmsByCriteria(); //По трем критериям
    }
}
