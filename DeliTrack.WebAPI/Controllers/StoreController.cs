using DeliTrack.Application.Features.StoreFeatures.CreateStore;
using DeliTrack.Application.Features.StoreFeatures.GetAllStores;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DeliTrack.WebAPI.Controllers
{
    [Route("api/store")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StoreController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllStoresResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllStoresRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateStoreResponse>> Create(CreateStoreRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
