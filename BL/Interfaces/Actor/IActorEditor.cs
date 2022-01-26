using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIx_CinemaSite.BL.Interfaces.Actor
{
    internal interface IActorEditor
    {
        void AddActor();//Добавить актера
        void EditTheActorInfo();//Редактировать данные актера
        void RemoveActor();//Удалить актера
    }
}
