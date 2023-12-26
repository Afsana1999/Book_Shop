using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class CategoryRepository : BaseRepository<Category, BookShopDbContext>, ICategoryRepository
    {
        public CategoryRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
