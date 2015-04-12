using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookStore.Dominio;

namespace BookStore.Repository
{
    public class BaseRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : EntityBase
        where TContext : DbContext
    {
        protected TContext Context;
        public BaseRepository(TContext context)
        {
            Context = context;
        }

        public void Create(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public IQueryable<TEntity> Get()
        {
            return Context.Set<TEntity>().AsQueryable();
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context = null;
        }
    }
}
