using MeControla.StockAnalytics.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace MeControla.StockAnalytics.Core.IoC
{
    internal static class ServiceInjector
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);

            services.TryAddScoped<IBrokerRetrieveFilterListService, BrokerRetrieveFilterListService>();
            services.TryAddScoped<IBrokerRetrieveListActiveService, BrokerRetrieveListActiveService>();
            services.TryAddScoped<IBrokerRetrieveService, BrokerRetrieveService>();
            services.TryAddScoped<IBrokerSaveService, BrokerSaveService>();
            services.TryAddScoped<IBrokerSwitchAtiveInactiveService, BrokerSwitchAtiveInactiveService>();

            services.TryAddScoped<ICompanyRetrieveFilterListService, CompanyRetrieveFilterListService>();
            services.TryAddScoped<ICompanyRetrieveListActiveService, CompanyRetrieveListActiveService>();
            services.TryAddScoped<ICompanyRetrieveService, CompanyRetrieveService>();
            services.TryAddScoped<ICompanySaveService, CompanySaveService>();
            services.TryAddScoped<ICompanySwitchAtiveInactiveService, CompanySwitchAtiveInactiveService>();

            services.TryAddScoped<IConsolidateAllTransactionsService, ConsolidateAllTransactionsService>();
            services.TryAddScoped<IConsolidatedRetrieveListByWalletIdWithAmountService, ConsolidatedRetrieveListByWalletIdWithAmountService>();

            services.TryAddScoped<IRegisterRetrieveFilterListService, RegisterRetrieveFilterListService>();
            services.TryAddScoped<IRegisterRetrieveService, RegisterRetrieveService>();
            services.TryAddScoped<IRegisterSaveService, RegisterSaveService>();
            services.TryAddScoped<IRegisterSwitchAtiveInactiveService, RegisterSwitchAtiveInactiveService>();

            services.TryAddScoped<ISynchronizeService, SynchronizeService>();

            services.TryAddScoped<ITickerRetrieveFilterListService, TickerRetrieveFilterListService>();
            services.TryAddScoped<ITickerRetrieveListActiveService, TickerRetrieveListActiveService>();
            services.TryAddScoped<IWalletRetrieveListActiveWithTickersService, WalletRetrieveListActiveWithTickersService>();
            services.TryAddScoped<ITickerRetrieveService, TickerRetrieveService>();
            services.TryAddScoped<ITickerSaveService, TickerSaveService>();
            services.TryAddScoped<ITickerSwitchAtiveInactiveService, TickerSwitchAtiveInactiveService>();

            services.TryAddScoped<ITransactionRetrieveFilterListService, TransactionRetrieveFilterListService>();
            services.TryAddScoped<ITransactionRetrieveService, TransactionRetrieveService>();
            services.TryAddScoped<ITransactionSaveService, TransactionSaveService>();

            services.TryAddScoped<IWalletRetrieveFilterListService, WalletRetrieveFilterListService>();
            services.TryAddScoped<IWalletRetrieveListActiveService, WalletRetrieveListActiveService>();
            services.TryAddScoped<IWalletRetrieveService, WalletRetrieveService>();
            services.TryAddScoped<IWalletSaveService, WalletSaveService>();
            services.TryAddScoped<IWalletSwitchAtiveInactiveService, WalletSwitchAtiveInactiveService>();

            return services;
        }
    }
}