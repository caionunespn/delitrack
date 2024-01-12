using DeliTrack.Application.Features.OrderFeatures.CreateOrder;
using DeliTrack.Application.Features.OrderFeatures.GetAllOrders;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DeliTrack.WebAPI.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllOrdersResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllOrdersRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateOrderResponse>> Create(CreateOrderRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
