using GMM.Application.Handlers.Commands.NotificationController;
using GMM.Application.Handlers.Queries.NotificationController;
using GMM.Application.Request.NotificationController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotificationController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var result = await _mediator.Send(new QueryFindAll());
            return Ok(result);
        }

        [HttpGet("FindId/{idNotification}")]
        public async Task<IActionResult> FindId(Guid idNotification)
        {
            var result = await _mediator.Send(new QueryFindId(idNotification));
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateNotificationRequest model)
        {
            var result = await _mediator.Send(new CommandCreate(model));
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateNotificationRequest model)
        {
            var result = await _mediator.Send(new CommandUpdate(model));
            return Ok(result);
        }

        [HttpDelete("Delete/{idNotification}")]
        public async Task<IActionResult> Delete(Guid idNotification)
        {
            var result = await _mediator.Send(new CommandDelete(idNotification));
            return Ok(result);
        }
    }
}
