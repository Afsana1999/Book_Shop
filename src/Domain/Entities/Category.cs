namespace BookShop.Domain.Entities;

public class Category : BaseAuditableEntity
{
    public Category()
    {
        Books = new HashSet<Book>();
        SubCategories=new HashSet<Category>();
    }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public bool IsMain { get; set; }
    public int? SupCategoryId { get; set; }
    public Category? SupCategory { get; set; }
    public virtual ICollection<Category> SubCategories { get; set; }
    public virtual ICollection<Book> Books { get; set; }

}
