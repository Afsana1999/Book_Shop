using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.Common.Constants
{
    public static class Messages
    {
        public static string DoesnotEmptyMessage(string message)
        {
            return message+" is required";
        }
    }
}
