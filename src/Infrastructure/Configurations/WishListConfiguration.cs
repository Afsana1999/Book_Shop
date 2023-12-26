using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Configurations
{
    public class WishListConfiguration : IEntityTypeConfiguration<WishList>
    {
        public void Configure(EntityTypeBuilder<WishList> builder)
        {
            //builder.HasOne(x => x.AppUser)
            //    .WithOne(x => x.WishList)
            //    .HasForeignKey<AppUser>(x => x.WishListId);
            //.OnDelete(DeleteBehavior.NoAction);
        }
    }
}
