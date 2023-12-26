namespace BookShop.Domain.Entities;

public class Country:BaseEntity
{
    public Country()
    {
        Addresses = new HashSet<Address>();
        States=new HashSet<State>();
    }
    public string Name { get; set; } = null!;
    public virtual ICollection<Address> Addresses { get; set; }
    public virtual ICollection<State> States { get; set; }
}
