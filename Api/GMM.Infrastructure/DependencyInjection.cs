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
    public static class Extensions
    {

        /// <summary>
        /// Agregamos la infraestructura de la aplicación.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        /// <param name="IsDevelopment"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration Configuration, bool IsDevelopment)
        {

            services.AddDbContext<BaseDbContext>(opstions => {
                opstions.UseSqlServer(Configuration.GetConnectionString("DEV_STANDAR"));
                if (IsDevelopment) {
                    opstions.LogTo(Console.WriteLine, LogLevel.Information)
                            .EnableSensitiveDataLogging();
                }
            });
           
            //agregamos todos los repositoprios genéricos en una sola linea.
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IMasterTableRepository, MasterTableRepository>();
            services.AddScoped<INotificationClassRepository, NotificationClassRepository>();
            services.AddScoped<IPlanningGroupRepository, PlanningGroupRepository>();
            services.AddScoped<IJobPositionRepository, JobPositionRepository>();
            services.AddScoped<IPriorityRepository, PriorityRepository>();
            services.AddScoped<ICauseRepository, CauseRepository>();
            services.AddScoped<IActivityRepository, ActivityRepository>();
            services.AddScoped<ISymptomFaultRepository, SymptomFaultRepository>();
            services.AddScoped<IFaultRepository, FaultRepository>();
            services.AddScoped<IMasterTableServices, MasterTableServices>();

            return services;
        }
    }
}
