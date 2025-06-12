using OrderService.Application.Abstractions.Orders;
using OrderService.Application.Models.Orders;

namespace OrderService.Infrastructure.Persistence.Orders;

public class OrderRepository : IOrderRepository
{
    public Task<Order> CreateOrderAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Order> GetOrderByIdAsync(Guid orderId)
    {
        throw new NotImplementedException();
    }

    public Task SoftDeleteOrderAsync(Guid orderId)
    {
        throw new NotImplementedException();
    }

    public Task<Order> ChangeOrderStatusAsync(Guid orderId, OrderStatus newStatus)
    {
        throw new NotImplementedException();
    }
}