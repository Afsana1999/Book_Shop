namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class DiscountRepository : BaseRepository<Discount, BookShopDbContext>, IDiscountRepository
    {
        public DiscountRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
