namespace BookShop.Domain.Entities;

public class Cart:BaseAuditableEntity
{
    public Cart()
    {
        CartItems = new HashSet<CartItem>();
    }
    public string AppUserId { get; set; }   
    public AppUser? AppUser { get; set; }
    public virtual ICollection<CartItem> CartItems { get; set; }

}
