using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIx_CinemaSite.BL.Interfaces.Films
{
    internal interface IFilmStatus
    {
        void GetFilmStatus(); //Получить текущий статус
        void ChangeStatusToRelease();//Сменить статус "скоро в прокате" на "премьера"
        void AddOnlineStatus();//Добавить статус на "онлайн"
        void RemoveReleaseStatus();//Убрать статус премьера
    }
}
