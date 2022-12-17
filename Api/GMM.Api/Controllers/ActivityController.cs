﻿using GMM.Application.Handlers.Commands.ActivityController;
using GMM.Application.Handlers.Queries.ActivityController;
using GMM.Application.Request.ActivityController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ActivityController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var result = await _mediator.Send(new QueryFindAll());
            return Ok(result);
        }

        [HttpGet("FindId/{idActivity}")]
        public async Task<IActionResult> FindId(Guid idActivity)
        {
            var result = await _mediator.Send(new QueryFindId(idActivity));
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateActivityRequest model)
        {
            var result = await _mediator.Send(new CommandCreate(model, this.GetCode(), this.GetHeader()));
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateActivityRequest model)
        {
            var result = await _mediator.Send(new CommandUpdate(model));
            return Ok(result);
        }

        [HttpDelete("Delete/{idActivity}")]
        public async Task<IActionResult> Delete(Guid idActivity)
        {
            var result = await _mediator.Send(new CommandDelete(idActivity));
            return Ok(result);
        }
    }
}
