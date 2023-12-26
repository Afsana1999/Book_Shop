

namespace Core.Repositories.Abstract;

public interface IRepository<TEntity> where TEntity : BaseEntity, new()
{
    Task<TEntity> AddAsync(TEntity entity,CancellationToken cancellationToken);
    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken);
    Task<TEntity> DeleteAsync(TEntity entity, CancellationToken cancellationToken);
    Task SaveChangesAsync(CancellationToken cancellationToken);
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, bool tracking = true, bool lazyLoading = false, CancellationToken cancellationToken=default, params string[] includes);
    Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, bool tracking = true, bool lazyLoading = false, CancellationToken cancellationToken=default, params string[] includes);
    Task<IEnumerable<TEntity>> GetAllAsync<TOrderKey>(Expression<Func<TEntity, TOrderKey>> orderBy, Expression<Func<TEntity, bool>> predicate = null, bool tracking = true, bool lazyLoading = false, CancellationToken cancellationToken = default, params string[] includes);
}
