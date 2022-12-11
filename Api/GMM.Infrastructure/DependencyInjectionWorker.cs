using GMM.Application.Interfaces.Repositories;
using GMM.Application.Interfaces.Services;
using GMM.Infrastructure.Persistence;
using GMM.Infrastructure.Repositories;
using GMM.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Infrastructure
{
    public static class ExtensionsWorker
    {

        /// <summary>
        /// Agregamos la infraestructura de la aplicación.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        /// <param name="IsDevelopment"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructureWorker(this IServiceCollection services, IConfiguration Configuration, bool IsDevelopment)
        {

            services.AddDbContext<BaseDbContext>(opstions => {
                opstions.UseSqlServer(Configuration.GetConnectionString("DEV_STANDAR"));
                if (IsDevelopment) {
                    opstions.LogTo(Console.WriteLine, LogLevel.Information)
                            .EnableSensitiveDataLogging();
                }
                //}, ServiceLifetime.Singleton, ServiceLifetime.Transient);
            }, ServiceLifetime.Transient, ServiceLifetime.Transient);

            //agregamos todos los repositoprios genéricos en una sola linea.
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IMasterTableRepository, MasterTableRepository>();
            services.AddTransient<IProccessRepository, ProccessRepository>();
            services.AddTransient<IProccessConfigurationRepository, ProccessConfigurationRepository>();

            services.AddTransient<IMasterTableServices, MasterTableServices>();



            return services;
        }
    }
}
