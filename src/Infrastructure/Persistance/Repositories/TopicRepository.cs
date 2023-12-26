namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class TopicRepository : BaseRepository<Topic, BookShopDbContext>, ITopicRepository
    {
        public TopicRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
