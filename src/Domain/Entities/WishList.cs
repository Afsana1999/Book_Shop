namespace BookShop.Domain.Entities;

public class WishList:BaseAuditableEntity
{
    public WishList()
    {
        Books = new HashSet<Book>();
    }
    public string AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public virtual ICollection<Book> Books { get; set; }
}