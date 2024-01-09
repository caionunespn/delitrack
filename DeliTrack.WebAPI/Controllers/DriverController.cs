using Microsoft.AspNetCore.Mvc;
using MediatR;
using DeliTrack.Application.Features.DriverFeatures.CreateDriver;
using DeliTrack.Application.Features.DriverFeatures.GetAllDrivers;

namespace DeliTrack.WebAPI.Controllers
{
    [Route("api/driver")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DriverController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllDriversResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllDriversRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateDriverResponse>> Create(CreateDriverRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
