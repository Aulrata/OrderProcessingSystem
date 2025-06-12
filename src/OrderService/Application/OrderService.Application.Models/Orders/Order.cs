namespace OrderService.Application.Models.Orders;

public record Order(
    long Id,
    long CustomerId,
    IEnumerable<OrderItem> Items,
    double TotalPrice,
    OrderStatus Status,
    DateTime CreatedAt,
    DateTime UpdatedAt);