namespace BookShop.Domain.Entities;

public class BookImage:BaseAuditableEntity
{
    public string ImagePath { get; set; } = null!;
    public int BookId { get; set; }
    public Book? Book { get; set; }
}
