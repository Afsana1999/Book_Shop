using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            //builder.HasOne(x => x.WishList)
            //     .WithOne(x => x.AppUser)
            //     .HasForeignKey<WishList>(x => x.AppUserId);
            //builder.HasOne(x => x.Cart)
            //        .WithOne(x => x.AppUser)
            //        .HasForeignKey<Cart>(x => x.AppUserId);
            //builder.HasMany(x => x.Orders)
            //    .WithOne(x => x.AppUser)
            //    .HasForeignKey(x => x.AppUserId)
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
