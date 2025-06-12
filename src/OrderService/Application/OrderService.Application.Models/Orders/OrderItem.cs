namespace OrderService.Application.Models.Orders;

public record OrderItem(long ProductId, int Quantity, double UnitPrice);