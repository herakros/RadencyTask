using Ardalis.Specification;
using System.Linq.Expressions;

namespace Radency.Contracts.Data
{
    public interface IRepository<TEntity> where TEntity : class, IBaseEntity
    {
        Task<TEntity> AddAsync(TEntity entity);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByKeyAsync<TKey>(TKey key);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);

        Task<int> SaveChangesAsync();

        Task<IEnumerable<TEntity>> GetListBySpecAsync(ISpecification<TEntity> specification);

        Task<TEntity> GetFirstBySpecAsync(ISpecification<TEntity> specification);
    }
}
