using Microsoft.AspNetCore.Mvc;
using MediatR;
using DeliTrack.Application.Features.DriverFeatures.CreateDriver;
using DeliTrack.Application.Features.DriverFeatures.GetAllDrivers;
using DeliTrack.Application.Features.DriverFeatures.UpdateDriver;

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

        [HttpPut("{id:Guid}")]
        public async Task<ActionResult<UpdateDriverResponse>> Update(Guid id, UpdateDriverRequest baseRequest, CancellationToken cancellationToken)
        {
            var request = new UpdateDriverCommand(
                id,
                baseRequest.Email,
                baseRequest.ShowPosition,
                baseRequest.Name,
                baseRequest.Address,
                baseRequest.City,
                baseRequest.State,
                baseRequest.PostalCode,
                baseRequest.Country,
                baseRequest.Phone,
                baseRequest.CurrentPosLatitude,
                baseRequest.CurrentPosLongitude
            );
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
