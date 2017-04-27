using System;
using System.Linq;
using System.Linq.Expressions;
using BusinessLogic.Interfaces;
using DataAccess.Repositories;
using DbEntity;

namespace BusinessLogic.Implementation
{
    public class CrudLogic<TEntity, TRepository> : ICrudLogic<TEntity> 
        where TEntity : IdEntity 
        where TRepository : ICrudRepository<TEntity>
    {
        protected readonly TRepository Repository;

        public CrudLogic(TRepository repository)
        {
            Repository = repository;
        }

        public TEntity GetById(Guid id)
        {
            return Repository.GetById(id);
        }

        public IQueryable<TEntity> GetAllItems()
        {
            return Repository.GetAll();
        }

        public IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate)
        {
            return Repository.Get(predicate);
        }

        public void Create(TEntity item)
        {
            Repository.Save(item);
        }

        public void Update(TEntity item)
        {
            Repository.Update(item);
        }

        public void DeleteById(Guid id)
        {
            Repository.Delete(id);
        }
    }
}
