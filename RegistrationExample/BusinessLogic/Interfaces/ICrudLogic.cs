using System;
using System.Linq;
using System.Linq.Expressions;
using DbEntity;

namespace BusinessLogic.Interfaces
{
    public interface ICrudLogic<TEntity> where TEntity : IdEntity
    {
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAllItems();
        IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate);
        void Create(TEntity item);
        void Update(TEntity item);
        void DeleteById(Guid id);
    }
}