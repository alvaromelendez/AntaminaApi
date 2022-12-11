using GMM.Application.Handlers.Commands.UploadFileController;
using GMM.Application.Request.UploadFileController;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reec.Inspection;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UploadController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(UploadRequest model)
        {
            var result = await _mediator.Send(new CommandCreate(model));
            return Ok(result);
        }
    }
}
