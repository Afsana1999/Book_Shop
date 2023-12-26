namespace BookShop.Infrastructure.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.Property(b => b.BookName).HasMaxLength(200).IsRequired(true);
        builder.Property(b => b.Description).IsRequired(true);
        //builder.Property(b => b.AuthorId).HasMaxLength(100).IsRequired(true);
        //builder.Property(b => b.CategoryId).IsRequired(true);
        //builder.Property(b => b.AppUserId).IsRequired(true);
        //builder.Property(b => b.CartItemId).IsRequired(true);
        //builder.Property(b => b.TopicId).IsRequired(true);
        //builder.Property(b => b.WishListId).IsRequired(true);
        builder.Property(b => b.Quantity).IsRequired(true);
        builder.Property(b => b.DiscountPercent).IsRequired(true);
        builder.HasMany(b => b.WishLists)
            .WithMany(b => b.Books)
            .UsingEntity<Dictionary<string, object>>(
                "BookWishlist",
                   j => j.HasOne<WishList>()
                    .WithMany()
                    .HasForeignKey("WishListId")
                    .HasConstraintName("FK_BookWishlist_Wishlists_WislistId")
                    .OnDelete(DeleteBehavior.Restrict),
                   j => j
                    .HasOne<Book>()
                    .WithMany()
                    .HasForeignKey("BookId")
                    .HasConstraintName("FK_BookWishlist_Books_BookId")
                    .OnDelete(DeleteBehavior.Restrict));
        builder.HasMany(x => x.Comments)
            .WithOne(x => x.Book)
            .HasForeignKey(x => x.BookId)
            .OnDelete(DeleteBehavior.Restrict);

        //builder.HasOne(x => x.CartItem)
        //        .WithOne(x => x.Book)
        //        .HasForeignKey<CartItem>(x => x.BookId);
        //builder.HasOne(c => c.Category)
        //    .WithMany(b => b.Books)
        //    .HasForeignKey(x => x.CategoryId);

        //builder.HasOne(t => t.Topic)
        //    .WithMany(b => b.Books)
        //    .HasForeignKey(t => t.TopicId);

        //builder.HasOne(a => a.AppUser)
        //    .WithMany(b => b.Books)
        //    .HasForeignKey(x => x.AppUserId);


    }
}
