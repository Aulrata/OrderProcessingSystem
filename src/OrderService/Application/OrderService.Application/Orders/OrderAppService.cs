using OrderService.Application.Contracts.Orders;
using OrderService.Application.Models.Orders;

namespace OrderService.Application.Orders;

public class OrderAppService : IOrderAppService
{
    public Task<Order> CreateOrderAsync()
    {
        throw new NotImplementedException();
    }
}