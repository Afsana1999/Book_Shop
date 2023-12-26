namespace BookShop.Infrastructure.Configurations;

public class BookImageConfiguration : IEntityTypeConfiguration<BookImage>
{
    public void Configure(EntityTypeBuilder<BookImage> builder)
    {
            builder.Property(i => i.ImagePath).IsRequired(true);
            builder.HasOne(b => b.Book)
                .WithMany(i => i.BookImages)
                .HasForeignKey(b => b.BookId);
    }
}
