namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class BookImageRepository : BaseRepository<BookImage, BookShopDbContext>, IBookImageRepository
    {
        public BookImageRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
