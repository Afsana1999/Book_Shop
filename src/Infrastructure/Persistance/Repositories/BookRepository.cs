namespace BookShop.Infrastructure.Persistance.Repositories;

public class BookRepository : BaseRepository<Book, BookShopDbContext>, IBookRepository
{
    public BookRepository(BookShopDbContext context) : base(context)
    {
    }
}
