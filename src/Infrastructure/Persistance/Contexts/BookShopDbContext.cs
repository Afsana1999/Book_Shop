using Microsoft.EntityFrameworkCore;

namespace BookShop.Infrastructure.Persistance.Contexts;

public class BookShopDbContext : IdentityDbContext<AppUser, AppRole, string>
{
    private readonly AuditableEntitySaveChangesInterceptors _auditableEntitySaveChangesInterceptors;
    public BookShopDbContext(DbContextOptions<BookShopDbContext> options, AuditableEntitySaveChangesInterceptors auditableEntitySaveChangesInterceptors) : base(options)
    {
        _auditableEntitySaveChangesInterceptors = auditableEntitySaveChangesInterceptors;

    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptors);
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookImage> BookImages { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Format> Formats { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderMethod> OrderMethods { get; set; }
    public DbSet<Price> Prices { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<WishList> WishLists { get; set; }

}
