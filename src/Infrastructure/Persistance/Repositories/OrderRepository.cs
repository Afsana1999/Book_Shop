namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class OrderRepository : BaseRepository<Order, BookShopDbContext>, IOrderRepository
    {
        public OrderRepository(BookShopDbContext context) : base(context)
        {
        }
    }
    public class CityRepository : BaseRepository<City, BookShopDbContext>, ICityRepository
    {
        public CityRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
