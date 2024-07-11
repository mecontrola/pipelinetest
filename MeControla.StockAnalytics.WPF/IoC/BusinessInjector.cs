using MeControla.StockAnalytics.WPF.Business;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace MeControla.StockAnalytics.WPF.IoC
{
    internal static class BusinessInjector
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);

            services.TryAddScoped<IBrokerBusiness, BrokerBusiness>();
            services.TryAddScoped<ICompanyBusiness, CompanyBusiness>();
            services.TryAddScoped<IConsolidatedBusiness, ConsolidatedBusiness>();
            services.TryAddScoped<IRegisterBusiness, RegisterBusiness>();
            services.TryAddScoped<ISynchronizeBusiness, SynchronizeBusiness>();
            services.TryAddScoped<ITickerBusiness, TickerBusiness>();
            services.TryAddScoped<ITransactionBusiness, TransactionBusiness>();
            services.TryAddScoped<IWalletBusiness, WalletBusiness>();

            return services;
        }
    }
}