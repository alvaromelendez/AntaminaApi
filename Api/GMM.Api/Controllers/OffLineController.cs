using GMM.Application.Handlers.Queries.OffLineController;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffLineController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OffLineController(IMediator mediator)
        {
            this._mediator = mediator;
        }
         
        [HttpGet("OffLineAll")]
        public async Task<IActionResult> OffLineAll()
        {
            var result = await _mediator.Send(new QueryOffLineAll());

             return Ok(result);
        }



    }

}
