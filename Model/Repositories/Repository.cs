using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Model.Repositories.Interfaces;
using Model.Database;
using Model.Factories.Interfaces;

namespace Model.Repositories
{
    public class Repository<TEntity> :IRepository<TEntity> where TEntity : class
    {
        protected EducationDbContext dbContext;

        public Repository(IEducationDbContextFactory DbContextFactory)
        {
            this.dbContext = DbContextFactory.DbContext;
        }

        public TEntity Get(int id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return dbContext.Set<TEntity>().Where(predicate);
        }

        public void Remove(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);

            dbContext.SaveChanges();
        }

        public void Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);

            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }

        //or

        bool disposed = false;

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposed)
        //    {
        //        if (disposing)
        //        {
        //            dbContext.Dispose();
        //        }
                
        //        disposed = true;
        //    }
        //}

        //~Repository()
        //{
        //    Dispose(false);
        //    Console.Beep();
        //}

    }
}