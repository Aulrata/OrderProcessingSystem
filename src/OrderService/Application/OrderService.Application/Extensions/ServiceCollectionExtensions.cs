using Microsoft.Extensions.DependencyInjection;
using OrderService.Application.Contracts.Orders;
using OrderService.Application.Orders;

namespace OrderService.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IOrderAppService, OrderAppService>();
        
        return collection;
    }
}