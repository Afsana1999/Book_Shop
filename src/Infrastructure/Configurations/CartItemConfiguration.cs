using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Configurations
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasOne(x => x.Cart)
                .WithMany(x => x.CartItems)
                .HasForeignKey(x => x.CartId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Order)
                .WithMany(x => x.CartItems)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
