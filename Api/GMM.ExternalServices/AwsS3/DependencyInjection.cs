﻿using GMM.ExternalServices.AwsS3;
using GMM.ExternalServices.AwsS3.Base;
using GMM.ExternalServices.AwsS3.EndPoint;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace GMM.ExternalServices.AwsS3
{
    public static class Extensions
    {

        /// <summary>
        /// Agregamos las conexiones para las apis de se de Antamina.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddAwsS3Antamina(this IServiceCollection services, Func<AwsS3AntaminaOptions> options)
        {
              
            var option = options.Invoke();
            services.AddSingleton(option);

            services.AddSingleton<IApiAwsS3, ApiAwsS3>();
            services.AddSingleton<IFileAws, FileAws>();

            //services.AddHttpContextAccessor();
            //services.AddHttpClient<IApiServiceProgrammed, ApiServiceProgrammed>(client =>
            //{
            //    client.BaseAddress = new Uri(option.Uri);
            //    ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            //    client.DefaultRequestHeaders.Clear();
            //});
            //services.AddSingleton<ISecurityServices, SecurityServices>();
            //services.AddSingleton<IAuthentication, Authentication>();

            return services;
        }
    }
}
