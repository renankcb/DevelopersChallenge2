using BankReconciliation.Application.Services;
using BankReconciliation.Domain.Repositories;
using BankReconciliation.Domain.Services;
using BankReconciliation.Infrastructure.Data.Persistense.EF.Contexts;
using BankReconciliation.Infrastructure.Data.Persistense.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BankReconciliation.API.Extensions
{
    public static class ServicesCollactionExtension
    {
        public static IServiceCollection AddServicesCollection(this IServiceCollection services)
        {
            services.AddScoped<IBankOperationAppService, BankOperationAppService>();
            services.AddScoped<IBankOperationDomainService, BankOperationDomainService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IBankExtractRepository, BankExtractRepository>();

            return services;
        }
    }
}
