using GMM.ExternalServices.ServiceUniversal.Base;
using GMM.ExternalServices.ServiceUniversal.EndPoint;
using Microsoft.Extensions.DependencyInjection;

namespace GMM.ExternalServices.ServiceUniversal
{
    public static class Extensions
    {
        public static IServiceCollection AddServiceUniversal(this IServiceCollection services, Func<ServiceUniversalOptions> options)
        {
            var option = options.Invoke();
            services.AddSingleton(option);
            services.AddHttpContextAccessor();
            /*services.AddHttpClient<IApiServiceProgrammed, ApiServiceProgrammed>(client =>
            {
                client.BaseAddress = new Uri(option.Uri);
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                client.DefaultRequestHeaders.Clear();
            });*/
            services.AddSingleton<IApiServiceUniversal, ApiServiceUniversal>();
            services.AddSingleton<IServiceUniversal, EndPoint.ServiceUniversal>();

            return services;
        }
    }
}
