using GMM.Application.Handlers.Commands.WorkOrderController;
using GMM.Application.Handlers.Queries.WorkOrderController;
using GMM.Application.Request.WorkOrderController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkOrderController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var result = await _mediator.Send(new QueryFindAll());
            return Ok(result);
        }

        [HttpGet("FindId/{idWorkOrder}")]
        public async Task<IActionResult> FindId(Guid idWorkOrder)
        {
            var result = await _mediator.Send(new QueryFindId(idWorkOrder));
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateWorkOrderRequest model)
        {
            var result = await _mediator.Send(new CommandCreate(model));
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateWorkOrderRequest model)
        {
            var result = await _mediator.Send(new CommandUpdate(model));
            return Ok(result);
        }

        [HttpDelete("Delete/{idWorkOrder}")]
        public async Task<IActionResult> Delete(Guid idWorkOrder)
        {
            var result = await _mediator.Send(new CommandDelete(idWorkOrder));
            return Ok(result);
        }
    }
}
