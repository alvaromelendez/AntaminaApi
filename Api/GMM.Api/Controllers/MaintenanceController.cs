using GMM.Application.Handlers.Queries.MaintenanceController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : Controller
    {
        private readonly IMediator _mediator;

        public MaintenanceController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var result = await _mediator.Send(new QueryFindAll());
            return Ok(result);
        }

        [HttpGet("FindId/{idOrder}")]
        public async Task<IActionResult> FindId(Guid idOrder)
        {
            var result = await _mediator.Send(new QueryFindId(idOrder));
            return Ok(result);
        }
    }
}
