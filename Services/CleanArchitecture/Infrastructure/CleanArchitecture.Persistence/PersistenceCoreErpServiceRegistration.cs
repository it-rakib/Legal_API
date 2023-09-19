using CleanArchitecture.Domain.CoreErpModel;
using Common.Service.Repositories;
using Merchandising.Persistence.Repositories.CoreErp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Merchandising.Persistence
{
    public static class PersistenceCoreErpServiceRegistration
    {
        public static IServiceCollection AddPersistenceCoreErpServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CoreERPContext>(options =>
                  options.UseSqlServer(configuration.GetConnectionString("coreErpConnectionsString")));
            services.AddScoped(typeof(IAsyncLegalRepository<>), typeof(CoreErpBaseRepository<>));

            //services.AddScoped<ICourtRepository, CourtRepository>();

            return services;
        }
    }
}
