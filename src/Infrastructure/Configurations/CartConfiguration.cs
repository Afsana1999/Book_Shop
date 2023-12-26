using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            //builder.HasOne(x => x.AppUser)
            //         .WithOne(x => x.Cart)
            //         .HasForeignKey<AppUser>(x => x.CartId);
        }
    }
}
