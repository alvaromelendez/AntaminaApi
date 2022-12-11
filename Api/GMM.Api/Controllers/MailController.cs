using GMM.Application.Handlers.Commands.Mail;
using GMM.Application.Handlers.Queries.Mail;
using GMM.ExternalServices.Mail.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MailController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost("SendMail")]
        public async Task<IActionResult> SendMail(MailRequest model)
        {
            var result = await _mediator.Send(new QuerySendMail(model, this.GetHeader(),this.GetCode()));
            return Ok(result);
        }

        [HttpPost("SendMail_V2")]
        public async Task<IActionResult> SendMail_V2(MailRequest model)
        {
            var result = await _mediator.Send(new CommandSendMail(model, this.GetHeader(), this.GetCode()));
            return Ok(result);
        }
    }
}
