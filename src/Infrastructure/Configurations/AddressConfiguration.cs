using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasOne(x => x.City)
                .WithMany(x => x.Addresses)
                .HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.State)
                .WithMany(x => x.Addresses)
                .HasForeignKey(x => x.StateId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
