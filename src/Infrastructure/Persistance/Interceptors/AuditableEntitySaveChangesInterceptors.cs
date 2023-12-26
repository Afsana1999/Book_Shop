using BookShop.Domain.Entities.BaseEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace BookShop.Infrastructure.Persistance.Interceptors;

public class AuditableEntitySaveChangesInterceptors : SaveChangesInterceptor
{
    private readonly IDateTimeService _dateTimeService;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuditableEntitySaveChangesInterceptors(IDateTimeService dateTimeService, IHttpContextAccessor httpContextAccessor)
    {
        _dateTimeService = dateTimeService;
        _httpContextAccessor = httpContextAccessor;
    }
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        UpdateEntities(eventData.Context);
        return base.SavingChanges(eventData, result);
    }
    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        UpdateEntities(eventData.Context);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }
    private void UpdateEntities(DbContext context)
    {
        if(context == null)return;

        foreach (var entry in context.ChangeTracker.Entries<BaseAuditableEntity>())
        {
            if (entry.State==EntityState.Added)
            {
                entry.Entity.CreatedDate = _dateTimeService.Now;
                entry.Entity.CreatedBy = _httpContextAccessor.HttpContext.User.Identity.Name;
            }else if (entry.State == EntityState.Modified)
            {
                entry.Entity.LastModifiedDate=_dateTimeService.Now;
                entry.Entity.LastModifiedBy= _httpContextAccessor.HttpContext.User.Identity.Name;
            }
        }
    }
}
