namespace BookShop.Application.Feutures.Books.Dtos;

public class BookDetailDto:IMapFrom<Book>
{
    public int Id { get; set; }
    public string BookName { get; set; } = null!;
    public string? Description { get; set; }
    public double DiscountPercent { get; set; }
    public int Quantity { get; set; }
    public Category? Category { get; set; }
    public Topic Topic { get; set; }
    public AppUser AppUser { get; set; }
    public WishList WishList { get; set; }
    public CartItem CartItem { get; set; }
    public Author Author { get; set; }
    public virtual ICollection<BookImage> BookImages { get; set; }
    public virtual ICollection<Comment> Comments { get; set; }
    public virtual ICollection<Price> Prices { get; set; }
}
