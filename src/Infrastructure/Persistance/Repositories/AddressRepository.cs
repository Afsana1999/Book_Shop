namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class AddressRepository : BaseRepository<Address, BookShopDbContext>, IAddressRepository
    {
        public AddressRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
