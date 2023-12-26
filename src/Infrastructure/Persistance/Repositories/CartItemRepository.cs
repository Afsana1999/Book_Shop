namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class CartItemRepository : BaseRepository<CartItem, BookShopDbContext>, ICartItemRepository
    {
        public CartItemRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
