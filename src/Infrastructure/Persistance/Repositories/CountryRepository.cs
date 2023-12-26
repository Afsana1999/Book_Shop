namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class CountryRepository : BaseRepository<Country, BookShopDbContext>, ICountryRepository
    {
        public CountryRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
