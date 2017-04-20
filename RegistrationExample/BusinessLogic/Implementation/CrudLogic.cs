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
        where TRepository : CrudRepository<TEntity>
    {
        private readonly TRepository _repository;

        public CrudLogic(TRepository repository)
        {
            _repository = repository;
        }

        public TEntity GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<TEntity> GetAllItems()
        {
            return _repository.GetAll();
        }

        public IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.Get(predicate);
        }

        public void Create(TEntity item)
        {
            _repository.Save(item);
        }

        public void Update(TEntity item)
        {
            _repository.Update(item);
        }

        public void DeleteById(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
