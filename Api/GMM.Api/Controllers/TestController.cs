using GMM.ExternalServices.ServiceProgrammed.EndPoint;
using GMM.ExternalServices.ServiceProgrammed.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reec.Inspection;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IAuthentication _authentication;

        public TestController(IAuthentication authentication)
        {
            this._authentication = authentication;
        }

        [HttpPost("SerializeObject")]
        public async Task<IActionResult> SerializeObject(EncryptRequest encryptRequest)
        {
            if (encryptRequest == null)
                throw new ReecException(ReecEnums.Category.Warning, "Debe ingresar un cuerpo de mensaje");
            else if (string.IsNullOrWhiteSpace(encryptRequest.Code))
                throw new ReecException(ReecEnums.Category.Warning, $"Debe ingresar un valor en la propiedad '{nameof(encryptRequest.Code)}'");
            else if (string.IsNullOrWhiteSpace(encryptRequest.TextTransform))
                throw new ReecException(ReecEnums.Category.Warning, $"Debe ingresar un valor en la propiedad '{nameof(encryptRequest.TextTransform)}'");

            var response = await _authentication.GetSerializeObject(encryptRequest);
            return Ok(response);

        }

        [HttpPost("GetUserToken")]
        public async Task<IActionResult> GetUserToken(LoginRequest loginRequest)
        {
            if (loginRequest == null)
                throw new ReecException(ReecEnums.Category.Warning, "Debe ingresar un cuerpo de mensaje");
            else if (string.IsNullOrWhiteSpace(loginRequest.IdToken))
                throw new ReecException(ReecEnums.Category.Warning, $"Debe ingresar un valor en la propiedad '{nameof(loginRequest.IdToken)}'");
            else if (string.IsNullOrWhiteSpace(loginRequest.AwsUserPool))
                throw new ReecException(ReecEnums.Category.Warning, $"Debe ingresar un valor en la propiedad '{nameof(loginRequest.AwsUserPool)}'");

            var response = await _authentication.GetUserToken(loginRequest);
            return Ok(response);

        }

        [HttpGet("Prueba")]
        public IActionResult Prueba(string customMessage)
        {
            return Ok($"Mensaje exitoso. {customMessage}");
        }




    }

}
