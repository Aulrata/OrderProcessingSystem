namespace OrderService.Application.Models.Orders;

public enum OrderStatus
{
    Created,
    Pending,
    Reserved,
    Failed,
    Cancelled,
    Finished,
}