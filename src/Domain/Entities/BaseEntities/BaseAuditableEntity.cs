namespace BookShop.Domain.Entities.BaseEntities;

public class BaseAuditableEntity : BaseEntity
{
    public string? CreatedBy { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}
