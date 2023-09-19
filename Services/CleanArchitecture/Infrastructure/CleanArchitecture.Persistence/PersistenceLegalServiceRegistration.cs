using CleanArchitecture.Application.Contracts.Persistence.LegalPersistence;
using CleanArchitecture.Domain.LegalModel;
using CleanArchitecture.Persistence.Repositories.Legal;
using Common.Service.Repositories;
using Merchandising.Persistence.Repositories.Legal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Merchandising.Persistence
{
    public static class PersistenceLegalServiceRegistration
    {
        public static IServiceCollection AddPersistenceLegalServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LEGALDBContext>(options =>
                  options.UseSqlServer(configuration.GetConnectionString("legalConnectionsString")));
            services.AddScoped(typeof(IAsyncLegalRepository<>), typeof(LegalBaseRepository<>));

            services.AddScoped<ICourtRepository, CourtRepository>();
            services.AddScoped<ILawyerInfoRepository, LawyerRepository>();
            services.AddScoped<IJurisdictionRepository, JurisdictionRepository>();
            services.AddScoped<ICaseTypeRepository, CaseTypeRepository>();
            services.AddScoped<IFileTypeRepository, FileTypeRepository>();
            services.AddScoped<IMatterRepository, MatterRepository>();
            services.AddScoped<ICasefileMasterRepository, CaseFileMasterRepository>();
            services.AddScoped<ICmnDocumentRepository, CmnDocumentRepository>();
            services.AddScoped<IUpdateDiaryRepository, UpdateDiaryRepository>();
            services.AddScoped<IExpenseRepository, ExpenseRepository>();
            services.AddScoped<ICmnDocumentRepository, CmnDocumentRepository>();
            services.AddScoped<IDashboardRepository, DashboardRepository>();
            services.AddScoped<IExpenseReportRepository, ExpenseReportRepository>();
            services.AddScoped<IDistrictWiseJurisdictionRepository, DistrictWiseJurisdictionRepository>();
            services.AddScoped<IStatusRepository, StatusRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IOnBehalfOfRepository, OnBehalfOfRepository>();

            return services;
        }
    }
}
