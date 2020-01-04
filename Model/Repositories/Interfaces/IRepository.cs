using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Model.Repositories.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity: class
    {
        TEntity Get(int id);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

        void Remove(TEntity entity);

        void Add(TEntity entity);        
    }
}
