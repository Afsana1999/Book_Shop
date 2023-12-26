namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class LanguageRepository : BaseRepository<Language, BookShopDbContext>, ILanguageRepository
    {
        public LanguageRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
