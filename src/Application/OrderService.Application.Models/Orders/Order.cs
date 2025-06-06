namespace OrderService.Application.Models.Orders;

public record Order(
    Guid Id,
    Guid CustomerId,
    IEnumerable<OrderItem> Items,
    double TotalPrice,
    OrderStatus Status,
    DateTime CreatedAt,
    DateTime UpdatedAt);