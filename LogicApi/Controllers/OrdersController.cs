using LogicApi.Entities;
using LogicApi.Requests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]   
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _mediator.Send(new Get());
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(string id)
        {
            var order = await _mediator.Send(new Get { Id = id });
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] Order order)
        {
            var createdOrder = await _mediator.Send(new Create { Order = order });
            return Ok(createdOrder);
        }

        [HttpGet("{id}/complete")]
        public async Task<IActionResult> Complete(string id)
        {
            var order = await _mediator.Send(new Complete { Id = id });
            return Ok(order);
        }

    }
}
