using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //builder.Property(x => x.Name).IsRequired();
            //builder.HasMany(x => x.SubCategories)
            //    .WithOne(x => x.SupCategory)
            //    .HasForeignKey(x => x.SupCategoryId);
                //.OnDelete(DeleteBehavior.Restrict);
        }
    }
}
