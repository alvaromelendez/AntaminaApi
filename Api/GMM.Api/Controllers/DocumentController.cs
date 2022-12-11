using GMM.Application.Handlers.Commands.DocumentController;
using GMM.Application.Handlers.Queries.DocumentController;
using GMM.Application.Request.DocumentController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DocumentController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var result = await _mediator.Send(new QueryFindAll());
            return Ok(result);
        }

        [HttpGet("FindId/{idDocument}")]
        public async Task<IActionResult> FindId(Guid idDocument)
        {
            var result = await _mediator.Send(new QueryFindId(idDocument));
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateDocumentRequest model)
        {
            var result = await _mediator.Send(new CommandCreate(model));
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateDocumentRequest model)
        {
            var result = await _mediator.Send(new CommandUpdate(model));
            return Ok(result);
        }

        [HttpDelete("Delete/{idDocument}")]
        public async Task<IActionResult> Delete(Guid idDocument)
        {
            var result = await _mediator.Send(new CommandDelete(idDocument));
            return Ok(result);
        }
    }
}
