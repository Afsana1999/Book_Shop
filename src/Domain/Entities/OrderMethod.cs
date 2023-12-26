namespace BookShop.Domain.Entities;

public class OrderMethod:BaseEntity
{
    public OrderMethod()
    {
        Orders = new HashSet<Order>();
    }
    public string Name { get; set; } = null!;
    public virtual ICollection<Order> Orders { get; set; }
}