using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIx_CinemaSite.DAL.Interfaces
{
    public interface IRepository 
    {
        public void GetInfo();
        public void Add();
        public void Change();
        public void Delete();
        public void GetList();

    }
}
