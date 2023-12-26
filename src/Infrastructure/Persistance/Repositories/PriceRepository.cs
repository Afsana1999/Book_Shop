namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class PriceRepository : BaseRepository<Price, BookShopDbContext>, IPriceRepository
    {
        public PriceRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
