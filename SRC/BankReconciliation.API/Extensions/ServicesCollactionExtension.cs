using BankReconciliation.Application.Services;
using BankReconciliation.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BankReconciliation.API.Extensions
{
    public static class ServicesCollactionExtension
    {
        public static IServiceCollection AddServicesCollection(this IServiceCollection services)
        {
            services.AddScoped<IReconciliationAppService, ReconciliationAppService>();
            services.AddScoped<IReconciliationDomainService, ReconciliationDomainService>();

            return services;
        }
    }
}
