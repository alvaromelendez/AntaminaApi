using GMM.Api.Model;
using GMM.ExternalServices.ServiceProgrammed.EndPoint;
using GMM.ExternalServices.ServiceProgrammed.Models;
using GMM.ExternalServices.ServiceUniversal.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Reec.Inspection;
using System.Threading.Tasks;

namespace GMM.Api.Services
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ValidationHeaderMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IAuthentication _authentication;

        public ValidationHeaderMiddleware(RequestDelegate next,
                                          IAuthentication authentication)
        {
            this._next = next;
            this._authentication = authentication;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Request.EnableBuffering();

            var code = httpContext.Request.Headers.FirstOrDefault(x => x.Key.ToLower() == "code");
            var header = httpContext.Request.Headers.FirstOrDefault(x => x.Key.ToLower() == "header");
            var token = httpContext.Request.Headers.FirstOrDefault(x => x.Key.ToLower() == "token");
            var identityPool = httpContext.Request.Headers.FirstOrDefault(x => x.Key.ToLower() == "identitypool");

            if (!string.IsNullOrWhiteSpace(token.Value) && !string.IsNullOrWhiteSpace(identityPool.Value))
            {
                var response = await this._authentication.GetUserToken(
                         new LoginRequest
                         {
                             IdToken = token.Value,
                             AwsUserPool = identityPool.Value
                         });

                if (!response.IsSuccess && response.Message == "No autorizado")
                    throw new ReecException(ReecEnums.Category.Unauthorized, "Los parametros de 'Token' y 'IdentityPool' han expirado.");
                else if (!response.IsSuccess)
                    throw new ReecException(ReecEnums.Category.BadGateway, "Ocurrio un error en el Servicio programado al recuperar información 'Token' y 'IdentityPool'.", response.Message);
                else if (!response.Result)
                    throw new ReecException(ReecEnums.Category.Warning, "El parametro 'Token' no es correcto.", response.Message);

            }
            else if (!string.IsNullOrWhiteSpace(code.Value) && !string.IsNullOrWhiteSpace(header.Value))
            {

                var response = await this._authentication.GetDeserializeObject(
                          new EncryptRequest { Code = code.Value, TextTransform = header.Value });

                if (!response.IsSuccess && response.Message == "No autorizado")
                    throw new ReecException(ReecEnums.Category.Unauthorized, "Los parametros de 'Code' y 'Header' han expirado.");
                else if (!response.IsSuccess)
                    throw new ReecException(ReecEnums.Category.BadGateway, "Ocurrio un error en el Servicio programado al recuperar información 'Code' y 'Header'.", response.Message);

                if (response.IsSuccess)
                {
                    var userModel = JsonConvert.DeserializeObject<UserModel>(response.Result.Value);
                    if (userModel.TimeExpiration > 0 && this.ValidatedTimeExpire(userModel.TimeExpiration))
                        throw new ReecException(ReecEnums.Category.Unauthorized, "El parametro 'Header' ha expirado.");
                }


            }
            else
            {
                throw new ReecException(ReecEnums.Category.Warning,
                     new List<string>
                     {
                        "Enviar los parametros opcionales 'Header' y 'Code' en la cabecera del request.",
                        "Enviar los parametros opcionales 'Token' y 'IdentityPool' en la cabecera del request."
                     }
                    );
            }

            await _next(httpContext);
        }


        public bool ValidatedTimeExpire(long timeSecondsEnd)
        {
            var timeSecondsNow =
                Convert.ToInt32((DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds);
            return timeSecondsNow > timeSecondsEnd;
        }


    }


    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ValidationHeaderMiddlewareExtensions
    {

        /// <summary>
        /// Valida si las peticiones Request tiene los parametros de cabecera "Code" y Header"
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseValidationHeader(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ValidationHeaderMiddleware>();
        }
    }




}
