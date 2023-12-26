namespace BookShop.Domain.Entities;

public class State:BaseEntity
{
    public State()
    {
        Cities = new HashSet<City>();
        Addresses=new HashSet<Address>();
    }
    public string Name { get; set; } = null!;
    public int CountryId { get; set; }
    public Country? Country { get; set; }
    public virtual ICollection<City> Cities { get; set; }
    public virtual ICollection<Address> Addresses { get; set; }

}