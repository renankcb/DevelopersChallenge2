using BankReconciliation.Application.Services;
using BankReconciliation.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BankReconciliation.API.Extensions
{
    public static class ServicesCollactionExtension
    {
        public static IServiceCollection AddServicesCollection(this IServiceCollection services)
        {
            services.AddScoped<IBankOperationAppService, BankOperationAppService>();
            services.AddScoped<IBankOperationDomainService, BankOperationDomainService>();

            return services;
        }
    }
}
