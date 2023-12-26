namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class AuthorRepository : BaseRepository<Author, BookShopDbContext>, IAuthorRepository
    {
        public AuthorRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
