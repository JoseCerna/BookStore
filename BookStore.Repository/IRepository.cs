using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Dominio;

namespace BookStore.Repository
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : EntityBase
    {
        void Create(TEntity entity);
        IQueryable<TEntity> Get();
        void Update(TEntity entity);
    }
}
