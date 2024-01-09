using DeliTrack.Application.Features.CustomerFeatures.CreateCustomer;
using DeliTrack.Application.Features.CustomerFeatures.GetAllCustomers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeliTrack.WebAPI.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllCustomersResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllCustomersRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateCustomerResponse>> Create(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
