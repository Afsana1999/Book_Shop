namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class OrderMethodRepository : BaseRepository<OrderMethod, BookShopDbContext>, IOrderMethodRepository
    {
        public OrderMethodRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
