using Antamina.ApiHost.Common;
using Antamina.ApiHost.Proxy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Antamina.ApiHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AntaminaController : ControllerBase
    {
        private readonly ILogger<AntaminaController> _logger;
        private readonly ServiceClient _serviceClient;
        public AntaminaController(ILogger<AntaminaController> logger, IOptions<ApiCredential> credential, IOptions<UrlApis> urlApis)
        {
            _logger = logger;
            _serviceClient = new ServiceClient(credential, urlApis);
        }

        [HttpGet]
        [Route("GetNoticationAll")]
        public async Task<ActionResult> GetNoticationAll()
        {
            var response = await _serviceClient.Get();
            return Ok(response);
        }

        [HttpGet]
        [Route("GetNotificationByID")]
        public async Task<ActionResult> GetNotificationByID()
        {
            return Ok();
        }

        [HttpPost]
        [Route("CreateNotification")]
        public async Task<ActionResult> CreateNotification()
        {
            return Ok();
        }
    }
}