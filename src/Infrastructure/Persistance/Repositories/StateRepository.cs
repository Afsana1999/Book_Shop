namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class StateRepository : BaseRepository<State, BookShopDbContext>, IStateRepository
    {
        public StateRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
