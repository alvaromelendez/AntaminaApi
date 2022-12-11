using GMM.Application.Handlers.Commands.FaultController;
using GMM.Application.Handlers.Queries.FaultController;
using GMM.Application.Request.FaultController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaultController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FaultController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var result = await _mediator.Send(new QueryFindAll());
            return Ok(result);
        }

        [HttpGet("FindId/{idFault}")]
        public async Task<IActionResult> FindId(Guid idFault)
        {
            var result = await _mediator.Send(new QueryFindId(idFault));
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateFaultRequest model)
        {
            var result = await _mediator.Send(new CommandCreate(model));
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateFaultRequest model)
        {
            var result = await _mediator.Send(new CommandUpdate(model));
            return Ok(result);
        }

        [HttpDelete("Delete/{idFault}")]
        public async Task<IActionResult> Delete(Guid idFault)
        {
            var result = await _mediator.Send(new CommandDelete(idFault));
            return Ok(result);
        }
    }
}
