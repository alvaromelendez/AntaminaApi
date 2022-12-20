using GMM.Application.Handlers.Commands.CauseController;
using GMM.Application.Handlers.Queries.CauseController;
using GMM.Application.Request.CauseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CauseController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CauseController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var result = await _mediator.Send(new QueryFindAll());
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateCauseRequest model)
        {
            var result = await _mediator.Send(new CommandCreate(model, this.GetCode(), this.GetHeader()));
            return Ok(result);
        }
    }
}
