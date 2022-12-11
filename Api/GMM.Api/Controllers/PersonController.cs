using GMM.Application.Handlers.Commands.PersonController;
using GMM.Application.Handlers.Queries.PersonController;
using GMM.Application.Models;
using GMM.Application.Request.PersonController;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var result = await _mediator.Send(new QueryFindAll());
            return Ok(result);
        }

        [HttpGet("FindId/{idPerson}")]
        public async Task<IActionResult> FindId(Guid idPerson)
        {
            var code = this.GetCode();
            var header = this.GetHeader();
            var result = await _mediator.Send(new QueryFindId(idPerson, this.GetCode(), this.GetHeader()));
            return Ok(result);
        }


        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateRequest model)
        {
            var result = await _mediator.Send(new CommandCreate(model));
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateRequest model)
        {
            var result = await _mediator.Send(new CommandUpdate(model));
            return Ok(result);
        }

        [HttpDelete("Delete/{idPerson}")]
        public async Task<IActionResult> Delete(Guid idPerson)
        {
            var result = await _mediator.Send(new CommandDelete(idPerson));
            return Ok(result);
        }
    }

}
