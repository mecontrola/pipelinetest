using MeControla.Core.Integrations.B3;
using MeControla.StockAnalytics.DataStorage.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MeControla.StockAnalytics.Core.IoC
{
    public static class CoreInjector
    {
        public static IServiceCollection AddCoreInjectors(this IServiceCollection services, IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(services);

            return services.AddRepositories(configuration)
                           .AddBusiness()
                           .AddMappers()
                           .AddServices()
                           .AddValidators()
                           .AddB3Integration();
        }
    }
}