using GMM.Common.Excel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GMM.Common 
{
    public static class Extensions
    {

        /// <summary>
        /// Agregamos los servicios comunes de generación de excel, lectura de excel.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddCommon(this IServiceCollection services)
        {
          
            services.AddSingleton<IGenerateExcel, GenerateExcel>();

            return services;
        }
    }
}
