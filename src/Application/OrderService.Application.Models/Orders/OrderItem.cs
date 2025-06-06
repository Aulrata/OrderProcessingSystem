namespace OrderService.Application.Models.Orders;

public record OrderItem(Guid ProductId, int Quantity, double UnitPrice);