namespace Core.Repositories.Concrete;

public class BaseRepository<TEntity,TContext>:IRepository<TEntity> where TEntity:BaseEntity, new()
    where TContext : DbContext
{
    private readonly TContext _context;
    public BaseRepository(TContext context)
    {
        _context = context;
    }
    public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken)
    {
        _context.Entry(entity).State = EntityState.Added;
        return entity;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken)
    {
        _context.Entry(entity).State = EntityState.Modified;
        return entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity, CancellationToken cancellationToken)
    {
        _context.Entry(entity).State = EntityState.Deleted;
        return entity;
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, bool tracking = true, bool lazyLoading=false, CancellationToken cancellationToken = default, params string[] includes)
    {
        IQueryable<TEntity> query = GetQuery(includes);
        if (!tracking)
            query = _context.Set<TEntity>().AsNoTracking();
        if (lazyLoading)        
            await _context.Set<TEntity>().LoadAsync(cancellationToken);
        
        return await query.Where(predicate).SingleOrDefaultAsync(cancellationToken);
    }
    public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, bool tracking = true, bool lazyLoading = false, CancellationToken cancellationToken = default, params string[] includes)
    {
        IQueryable<TEntity> query = GetQuery(includes);
        if (!tracking)
            query = _context.Set<TEntity>().AsNoTracking();
        if (lazyLoading)
            await _context.Set<TEntity>().LoadAsync(cancellationToken);

        return predicate is null
            ? await query.ToListAsync(cancellationToken)
            : await query.Where(predicate).ToListAsync(cancellationToken);
    }
    public async Task<IEnumerable<TEntity>> GetAllAsync<TOrderKey>(Expression<Func<TEntity, TOrderKey>> orderBy, Expression<Func<TEntity, bool>> predicate = null, bool tracking = true,bool lazyLoading=false, CancellationToken cancellationToken = default, params string[] includes)
    {
        IQueryable<TEntity> query = GetQuery(includes);
        if (!tracking)
            query = _context.Set<TEntity>().AsNoTracking();
        if (lazyLoading)
           await _context.Set<TEntity>().LoadAsync(cancellationToken);
        
        return predicate is null
            ?  await query.OrderBy(orderBy).ToListAsync(cancellationToken)
            : await query.Where(predicate).OrderBy(orderBy).ToListAsync(cancellationToken);
    }
    private IQueryable<TEntity> GetQuery(params string[] includes)
    {
        var query = _context.Set<TEntity>().AsQueryable();
        if (includes != null)
        {
            foreach (var item in includes)
            {
                query = query.Include(item);
            }
        }
        return query;
    }

}
