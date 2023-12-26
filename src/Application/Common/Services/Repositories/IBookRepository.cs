using BookShop.Domain.Entities;
using Core.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.Common.Services.Repositories
{
    public interface IBookRepository:IRepository<Book>
    {
    }
}
