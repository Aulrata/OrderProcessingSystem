using OrderService.Application.Models.Orders;

namespace OrderService.Application.Abstractions.Orders;

public interface IOrderRepository
{
    public Task<Order> CreateOrderAsync();
    
    public Task<Order> GetOrderByIdAsync(Guid orderId);
    
    public Task SoftDeleteOrderAsync(Guid orderId);
    
    public Task<Order> ChangeOrderStatusAsync(Guid orderId, OrderStatus newStatus);
}