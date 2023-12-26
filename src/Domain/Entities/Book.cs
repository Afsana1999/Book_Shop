namespace BookShop.Domain.Entities;

public class Book : BaseAuditableEntity
{
    public Book()
    {
        BookImages = new HashSet<BookImage>();
   
        Comments=new HashSet<Comment>();
        Prices=new HashSet<Price>();
        CartItems=new HashSet<CartItem>();
        WishLists=new HashSet<WishList>();
    }
    public string BookName { get; set; } = null!;
    public string? Description { get; set; }
    public double DiscountPercent { get; set; }
    public int Quantity { get; set; }

    //One to Many
    public int CategoryId { get; set; }
    public Category? Category { get; set; } 
    public int TopicId { get; set; }
    public Topic Topic { get; set; }
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
   
    //One to Many <->
    public virtual ICollection<BookImage> BookImages { get; set; }
    public virtual ICollection<Price> Prices { get; set; }
    public virtual ICollection<CartItem> CartItems { get; set; }
    public virtual ICollection<WishList> WishLists { get; set; }
    public virtual ICollection<Comment> Comments { get; set; }


    //Many to Many 



}
