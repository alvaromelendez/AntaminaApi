using Antamina.ApiHost.Common;
using Antamina.ApiHost.Entities.DTO;
using Antamina.ApiHost.Proxy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

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
            var response = await _serviceClient.GetNotificationAll();
            return Ok(response);
        }

        [HttpGet]
        [Route("GetNotificationByID")]
        public async Task<ActionResult> GetNotificationByID(string notificationID,  long sap_Client_ID)
        {
            var response = await _serviceClient.GetNotificationByID(notificationID, sap_Client_ID);
            return Ok(response);
        }

        [HttpPost]
        [Route("CreateNotification")]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> CreateNotification(string xCSRF_Token)
        {
            CreateNotificationRequest createNotificationRequest = new CreateNotificationRequest()
            {
                NotificationText = "Notification Test CV 10-11-2022 B",
                MaintPriority = 2,
                NotificationType = "M2",
                MalfunctionStartDate = DateTime.Now,
                MalfunctionStartTime = "PT23H15M19S",
                NotificationTimeZone = "UTC-5",
                TechnicalObject = "?0100000000000001788",
                TechObjIsEquipOrFuncnlLoc = "EAMS_FL",
                MaintenanceObjectIsDown = true,
                MainWorkCenter = "MECAMIO",
                ReportedByUser = "CVALES"
            };
            string request = System.Text.Json.JsonSerializer.Serialize(createNotificationRequest);
            var response = await _serviceClient.CreateNotification(request, xCSRF_Token);
            return Ok(response);
        }
    }
}