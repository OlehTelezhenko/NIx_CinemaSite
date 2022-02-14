using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_CinemaSite.BL.Intefaces.OnlineViewing
{
    public interface ISearchCreteria
    {
        void GetFilmsWithoutCriteria(); //дефолт, последнее поступившее
        void GetFilmsByCriteria(); //По одному критерию
    }
}
