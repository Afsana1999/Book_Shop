
namespace BookShop.Domain.Entities;

public class City:BaseEntity
{
    public City()
    {
            Addresses=new HashSet<Address>();
    }
    public string Name { get; set; }=null!;
    public int StateId { get; set; }
    public virtual State State { get; set; }
    public int AddressId { get; set; }
    public virtual ICollection<Address> Addresses { get; set; }

}