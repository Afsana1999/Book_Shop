using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        { 
        //    builder.HasOne(x => x.AppUser)
        //         .WithMany(x => x.Orders)
        //         .HasForeignKey(x => x.AppUserId);
        //    //.OnDelete(DeleteBehavior.NoAction);
        //    builder.HasMany(x=>x.CartItems)
        //        .WithOne(x=>x.Order)
        //        .HasForeignKey(x=>x.OrderId);
        }
    }
}
