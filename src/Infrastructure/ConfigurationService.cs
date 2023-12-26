using BookShop.Application.Common.Services.Repositories;
using BookShop.Infrastructure.Persistance.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace BookShop.Infrastructure;

public static class ConfigurationService
{
    public static IServiceCollection AddInfastructureServices(this IServiceCollection serviceCollection, IConfiguration configuration)
    {

        serviceCollection.AddHttpContextAccessor();
        serviceCollection.AddTransient<IDateTimeService, DateTimeService>();
        serviceCollection.AddScoped<AuditableEntitySaveChangesInterceptors>();
        serviceCollection.AddDbContext<BookShopDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
        builderOptions => builderOptions.MigrationsAssembly(typeof(BookShopDbContext).Assembly.FullName)
        ));

        serviceCollection.AddDefaultIdentity<AppUser>()
    .AddRoles<AppRole>()
    .AddEntityFrameworkStores<BookShopDbContext>();

        serviceCollection.AddScoped<IBookRepository, BookRepository>();
        serviceCollection.AddScoped<IAddressRepository, AddressRepository>();
        serviceCollection.AddScoped<IAuthorRepository, AuthorRepository>();
        serviceCollection.AddScoped<IBookImageRepository, BookImageRepository>();
        serviceCollection.AddScoped<ICartRepository, CartRepository>();
        serviceCollection.AddScoped<ICartItemRepository, CartItemRepository>();
        serviceCollection.AddScoped<ICategoryRepository, CategoryRepository>();
        serviceCollection.AddScoped<ICityRepository, CityRepository>();
        serviceCollection.AddScoped<ICommentRepository, CommentRepository>();
        serviceCollection.AddScoped<ICountryRepository, CountryRepository>();
        serviceCollection.AddScoped<IDiscountRepository, DiscountRepository>();
        serviceCollection.AddScoped<IFormatRepository, FormatRepository>();
        serviceCollection.AddScoped<ILanguageRepository, LanguageRepository>();
        serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
        serviceCollection.AddScoped<IOrderMethodRepository, OrderMethodRepository>();
        serviceCollection.AddScoped<IPriceRepository, PriceRepository>();
        serviceCollection.AddScoped<ISaleRepository, SaleRepository>();
        serviceCollection.AddScoped<IStateRepository, StateRepository>();
        serviceCollection.AddScoped<ITopicRepository, TopicRepository>();
        serviceCollection.AddScoped<IWishListRepository, WishListRepository>();


        return serviceCollection;
    }
}
