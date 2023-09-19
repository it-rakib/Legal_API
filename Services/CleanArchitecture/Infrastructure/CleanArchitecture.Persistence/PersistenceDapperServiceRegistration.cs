using CleanArchitecture.Domain.LegalModel;
using Merchandising.Application.Contracts.Persistence.LegalPersistence;
using Merchandising.Persistence.Repositories.Legal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Merchandising.Persistence
{
    public static class PersistenceDapperServiceRegistration
    {
        public static IServiceCollection AddPersistenceDapperServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LEGALDBContext>(options =>
                  options.UseSqlServer(configuration.GetConnectionString("legalConnectionsString")));
            services.AddScoped<IDapperRepository, DapperRepository>();

            return services;
        }
    }
}
