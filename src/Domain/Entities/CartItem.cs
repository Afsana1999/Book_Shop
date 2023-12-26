namespace BookShop.Domain.Entities;

public class CartItem:BaseAuditableEntity
{
    public int BookCount { get; set; }
    public double BookPrice { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public int CartId { get; set; }
    public Cart Cart { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
}
