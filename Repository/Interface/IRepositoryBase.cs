using System;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;
using TestandoRepositoryPattern.Model.Base;

namespace TestandoRepositoryPattern.Repository.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity,bool>> filter = null);
        Task<TEntity> GetPerId(Guid id);
        Task AddAsync(TEntity entity);
        Task Delete(TEntity entity);
        Task Update(TEntity entity);
    }
}