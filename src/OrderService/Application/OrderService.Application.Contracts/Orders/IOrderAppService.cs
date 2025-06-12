using OrderService.Application.Models.Orders;

namespace OrderService.Application.Contracts.Orders;

public interface IOrderAppService
{
    public Task<Order> CreateOrderAsync();
}