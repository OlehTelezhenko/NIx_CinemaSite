using Microsoft.EntityFrameworkCore;
using Nix_CinemaSite.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_CinemaSite.DAL.GenericRepositories
{
    public class GenericRepository<TEntity, TGuid> : IGenericRepository<TEntity, TGuid> where TEntity : class
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<TEntity> _dbSet;

        protected ApplicationContext Context => _context; //???

        public GenericRepository(DbContextOptions options)
        {
            _context = new ApplicationContext(options);
            _dbSet = _context.Set<TEntity>(); //set?
        }

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>(); //set?
        }

        public void Delete(TGuid id)
        {
            if (id == null) throw new ArgumentNullException("id");

            var entityToDelete = GetById(id);

            if (entityToDelete == null) throw new Exception("Entity not found");

            _context.Set<TEntity>().Remove(entityToDelete);
        }

        public void Delete(TEntity entityToDelete)
        {
            if (entityToDelete == null) throw new ArgumentNullException("entity");

            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _context.Set<TEntity>().Attach(entityToDelete);
            }

            _context.Set<TEntity>().Remove(entityToDelete);
        }

        //public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null)
        //{
        //    IQueryable<TEntity> query = _context.Set<TEntity>();

        //    if (predicate != null)
        //    {
        //        query = query.Where(predicate);
        //    }

        //    if (!string.IsNullOrEmpty(includeProperties) && !string.IsNullOrWhiteSpace(includeProperties))
        //    {
        //        foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //        {
        //            query = query.Include(includeProperty);
        //        }
        //    }

        //    if (orderBy != null)
        //    {
        //        return orderBy(query).AsEnumerable();
        //    }
        //    else
        //    {
        //        return query.AsEnumerable();
        //    }
        //}

        public TEntity GetById(TGuid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entityToInsert)
        {
            _context.Set<TEntity>().Attach(entityToInsert);
        }

        public void Update(TEntity entityToUpdate)
        {
            _context.Set<TEntity>().Attach(entityToUpdate);

            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
