namespace BookShop.Domain.Entities;

public class Author:BaseEntity
{
    public Author()
    {
        Books = new HashSet<Book>();
    }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Description { get; set; }
    public virtual ICollection<Book> Books { get; set; }

}
