namespace BookShop.Domain.Entities;

public class Comment:BaseAuditableEntity
{
    public Comment()
    {
        SubComments=new HashSet<Comment>();
    }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Rate { get; set; }

    public int SupCommentId { get; set; }
    public Comment SupComment { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public virtual ICollection<Comment> SubComments { get; set; }
}