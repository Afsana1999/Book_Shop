using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasMany(x => x.SubComments)
                .WithOne(x => x.SupComment)
                .HasForeignKey(x => x.SupCommentId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
