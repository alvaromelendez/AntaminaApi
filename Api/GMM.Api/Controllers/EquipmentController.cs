using GMM.Application.Handlers.Queries.EquipmentController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly IMediator _mediator;

        public EquipmentController(IMediator mediator)
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
