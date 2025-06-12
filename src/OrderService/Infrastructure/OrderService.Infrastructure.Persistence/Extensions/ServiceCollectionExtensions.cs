using Microsoft.Extensions.DependencyInjection;
using OrderService.Application.Abstractions.Orders;
using OrderService.Infrastructure.Persistence.Orders;

namespace OrderService.Infrastructure.Persistence.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection collection)
    {
        collection.AddScoped<IOrderRepository, OrderRepository>();
        
        return collection;
    }
}