namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class WishListRepository : BaseRepository<WishList, BookShopDbContext>, IWishListRepository
    {
        public WishListRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
