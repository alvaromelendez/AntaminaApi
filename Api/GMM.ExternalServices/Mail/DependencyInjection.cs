using GMM.ExternalServices.Mail.Base;
using GMM.ExternalServices.Mail.EndPoint;
using Microsoft.Extensions.DependencyInjection;

namespace GMM.ExternalServices.Mail
{
    public static class Extensions
    {
        /// <summary>
        /// Agregamos las conexiones para las apis de se de Antamina.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddMailAntamina(this IServiceCollection services, Func<MailOptions> options)
        {

            var option = options.Invoke();
            services.AddSingleton(option);

            services.AddSingleton<IApiMail, ApiMail>();
            services.AddSingleton<IMail, EndPoint.Mail>();

            return services;
        }
    }
}
