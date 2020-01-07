using Microsoft.Extensions.DependencyInjection;
using Poc.Api.Interfaces;
using Poc.Api.Services;

namespace Poc.Api.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection ConfigurarDependencias(this IServiceCollection services)
        {
            services.AddTransient<IBandasService, BandasService>();

            return services;
        } 
    }
}
