using GMM.Application.Handlers.Commands.FaultController;
using GMM.Application.Handlers.Queries.FaultController;
using GMM.Application.Request.FaultController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
        public async Task<IActionResult> Create(CreateFaultRequest model)
        {
            var result = await _mediator.Send(new CommandCreate(model, this.GetCode(), this.GetHeader()));
            return Ok(result);
        }

        //[HttpPut("Update")]
        //public async Task<IActionResult> Update(UpdateFaultRequest model)
        //{
        //    var result = await _mediator.Send(new CommandUpdate(model));
        //    return Ok(result);
        //}

        //[HttpDelete("Delete/{idFault}")]
        //public async Task<IActionResult> Delete(Guid idFault)
        //{
        //    var result = await _mediator.Send(new CommandDelete(idFault));
        //    return Ok(result);
        //}
    }
}
