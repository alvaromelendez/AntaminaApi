using GMM.ExternalServices.ServiceProgrammed.Base;
using GMM.ExternalServices.ServiceProgrammed.EndPoint;
using Microsoft.Extensions.DependencyInjection;
using System.Net;

namespace GMM.ExternalServices.ServiceProgrammed
{
    public static class Extensions
    {

        /// <summary>
        /// Agregamos las conexiones para las apis de servicio programado de Antamina.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddServiceProgrammed(this IServiceCollection services, Func<ServiceProgrammedOptions> options)
        {

            var option = options.Invoke();
            services.AddSingleton(option);
            services.AddHttpContextAccessor();
            services.AddHttpClient<IApiServiceProgrammed, ApiServiceProgrammed>(client =>
            {
                client.BaseAddress = new Uri(option.Uri);
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                client.DefaultRequestHeaders.Clear();
            });
            services.AddSingleton<ISecurityServices, SecurityServices>();
            services.AddSingleton<IAuthentication, Authentication>();


            
            return services;
        }
    }
}
