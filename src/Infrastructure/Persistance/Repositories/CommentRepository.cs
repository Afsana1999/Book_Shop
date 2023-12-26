namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class CommentRepository : BaseRepository<Comment, BookShopDbContext>, ICommentRepository
    {
        public CommentRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
