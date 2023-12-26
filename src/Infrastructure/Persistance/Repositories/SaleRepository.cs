namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class SaleRepository : BaseRepository<Sale, BookShopDbContext>, ISaleRepository
    {
        public SaleRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
