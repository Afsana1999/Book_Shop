using BookShop.Application.Common.Exceptioons;
using BookShop.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.Common.Helper.Exception
{
    public static class CommonExceptionHelper
    {
        public static void ResponseNotFoundExceptionHelper<TEntity>(TEntity entity)
            where TEntity:BaseEntity, new()
        {
            if (entity==null)
            {
                throw new NotFoundException(nameof(entity), entity);
            }
        }
        public static void ListResponseNotFoundExceptionHelper<TEntity>(TEntity entity)
    where TEntity : IEnumerable<BaseEntity>
        {
            if (entity == null)
            {
                throw new NotFoundException();
            }
        }
    }
}
