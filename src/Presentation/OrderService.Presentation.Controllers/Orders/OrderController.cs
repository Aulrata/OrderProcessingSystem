using Microsoft.AspNetCore.Mvc;
using OrderService.Application.Contracts.Orders;

namespace OrderService.Presentation.Controllers.Orders;

[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase
{
    private readonly IOrderAppService _orderAppService;

    public OrderController(IOrderAppService orderAppService)
    {
        _orderAppService = orderAppService;
    }

    public async Task<ActionResult> GetOrders()
    {
        // TODO: Добавить DTO 
        await _orderAppService.CreateOrderAsync();
        
        return Ok();
    }
}