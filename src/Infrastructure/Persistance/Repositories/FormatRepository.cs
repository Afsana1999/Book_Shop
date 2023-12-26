namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class FormatRepository : BaseRepository<Format, BookShopDbContext>, IFormatRepository
    {
        public FormatRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
