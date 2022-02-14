using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_CinemaSite.DAL.Interfaces
{
    public interface IGenericRepository<TEntity, TGuid> where TEntity : class
    {
        TEntity GetById(TGuid id);

        //IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");

        void Delete(TGuid id);

        void Delete(TEntity entityToDelete);

        void Insert(TEntity entityToInsert);

        void Update(TEntity entityToUpdate);
    }
}
