using BookShop.Application.Common.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Persistance.Repositories
{
    public class CartRepository : BaseRepository<Cart, BookShopDbContext>, ICartRepository
    {
        public CartRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}
