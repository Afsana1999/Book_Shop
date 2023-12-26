using BookShop.Application.Common.Behaviourus;
using BookShop.Application.Common.Services.Repositories;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BookShop.Application
{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());

            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly()); 

           serviceCollection.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            serviceCollection.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            return serviceCollection;
        }
    }
}
