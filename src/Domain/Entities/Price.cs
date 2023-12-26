namespace BookShop.Domain.Entities;

public class Price:BaseAuditableEntity
{  

    public double BookPrice { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public int DiscountId { get; set; }
    public Discount? Discount { get; set; }
    public virtual Language Language { get; set; }
    public virtual Format Format { get; set; }
}
