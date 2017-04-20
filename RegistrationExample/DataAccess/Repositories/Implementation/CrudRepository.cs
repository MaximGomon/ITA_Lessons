using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DbEntity;

namespace DataAccess.Repositories
{
    public class CrudRepository<TEntity> : ICrudRepository<TEntity> 
        where TEntity : IdEntity
    {
        protected readonly RegDbContext Context;

        public CrudRepository(RegDbContext context)
        {
            Context = context;
        }

        public CrudRepository()
        {
            Context = new RegDbContext();
        }

        public virtual TEntity GetById(Guid id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return Context.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public virtual void Save(TEntity item)
        {
            Context.Set<TEntity>().Add(item);
            Context.SaveChanges();
        }

        public virtual void Update(TEntity item)
        {
            Context.Entry(item).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public virtual void Delete(Guid id)
        {
            Context.Set<TEntity>().Remove(GetById(id));
            Context.SaveChanges();
        }
    }
}