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
        public async Task<IActionResult> FindAll([FromQuery] FindAllRequest request)
        {
            var result = await _mediator.Send(new QueryFindAll(request));
            return Ok(result);
        }

        [HttpGet("FindId")]
        public async Task<IActionResult> FindId([FromQuery] FindIdRequest request)
        {
            var result = await _mediator.Send(new QueryFindId(request));
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateNotificationRequest model)
        {
            var result = await _mediator.Send(new CommandCreate(model, this.GetCode(), this.GetHeader()));
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateNotificationRequest model)
        {
            var result = await _mediator.Send(new CommandUpdate(model));
            return Ok(result);
        }

        //[HttpDelete("Delete/{idNotification}")]
        //public async Task<IActionResult> Delete(Guid idNotification)
        //{
        //    var result = await _mediator.Send(new CommandDelete(idNotification));
        //    return Ok(result);
        //}
    }
}
