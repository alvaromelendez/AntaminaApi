using GMM.Application.Handlers.Queries.FunctionalLocationController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FunctionalLocationController : Controller
    {
        private readonly IMediator _mediator;

        public FunctionalLocationController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var result = await _mediator.Send(new QueryFindAll());
            return Ok(result);
        }
    }
}
