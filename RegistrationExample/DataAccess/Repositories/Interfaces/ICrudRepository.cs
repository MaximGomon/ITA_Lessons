using System;
using System.Linq;
using System.Linq.Expressions;
using DbEntity;

namespace DataAccess.Repositories
{
    public interface ICrudRepository<TEntity> where TEntity : IdEntity
    {
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        void Save(TEntity item);
        void Update(TEntity item);
        void Delete(Guid id);
    }
}