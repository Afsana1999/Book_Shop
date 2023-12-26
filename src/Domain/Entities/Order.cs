namespace BookShop.Domain.Entities;

public class Order:BaseAuditableEntity
{
    public Order()
    {
        CartItems=new HashSet<CartItem>();
    }
    public double TotalPrice { get; set; }
    public virtual ICollection<CartItem> CartItems { get; set; }
    public Address OrderAddress { get; set; }
    public int OrderMethodId { get; set; }
    public OrderMethod OrderMethod { get; set; }
    public string? AppUserId { get; set; }
    public AppUser AppUser { get; set; }

}
