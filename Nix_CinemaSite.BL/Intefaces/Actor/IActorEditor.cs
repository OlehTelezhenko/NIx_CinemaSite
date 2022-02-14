using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_CinemaSite.BL.Intefaces.Actor
{
    public interface IActorEditor
    {
        void AddActor();//Добавить актера
        void EditTheActorInfo();//Редактировать данные актера
        void RemoveActor();//Удалить актера
        void FilmsWithAnActor();//Фильмы в которых снялся актер
    }
}
