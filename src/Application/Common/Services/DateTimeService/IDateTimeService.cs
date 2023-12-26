using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.Common.Services.DateTimeService
{
    public interface IDateTimeService
    {
        DateTime Now { get; }
    }
}
