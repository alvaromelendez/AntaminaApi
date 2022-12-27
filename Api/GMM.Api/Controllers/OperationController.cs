using GMM.Application.Handlers.Queries.OperationController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : Controller
    {
        private readonly IMediator _mediator;

        public OperationController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("Find")]
        public async Task<IActionResult> Find()
        {
            var result = await _mediator.Send(new QueryFind());
            return Ok(result);
        }

        [HttpGet("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var result = await _mediator.Send(new QueryFindAll());
            return Ok(result);
        }

        [HttpGet("FindId/{idComponent}")]
        public async Task<IActionResult> FindId(Guid idComponent)
        {
            var result = await _mediator.Send(new QueryFindId(idComponent));
            return Ok(result);
        }
    }
}
