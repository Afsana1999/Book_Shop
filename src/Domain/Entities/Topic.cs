namespace BookShop.Domain.Entities;

public class Topic:BaseEntity
{
    public Topic()
    {
        Books = new HashSet<Book>();
    }
    public string Name { get; set; } = null!;
    public virtual ICollection<Book> Books { get; set; }
}
