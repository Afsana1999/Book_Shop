
namespace BookShop.Domain.Entities.Auth;
public class AppUser : IdentityUser
{
    public AppUser()
    {
        Books = new HashSet<Book>();
        Addresses = new HashSet<Address>();
        Comments = new HashSet<Comment>();
        Orders = new HashSet<Order>();
    }

    public Cart? Cart { get; set; }
    public WishList WishList { get; set; }
    public virtual ICollection<Book> Books { get; set; }
    public virtual ICollection<Address> Addresses { get; set; }
    public virtual ICollection<Comment> Comments { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
}
