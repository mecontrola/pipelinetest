using MeControla.StockAnalytics.Core.Validators;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace MeControla.StockAnalytics.Core.IoC
{
    internal static class ValidatorInjector
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);

            services.TryAddSingleton<IBrokerInputDtoValidator, BrokerInputDtoValidator>();
            services.TryAddSingleton<ICompanyInputDtoValidator, CompanyInputDtoValidator>();
            services.TryAddSingleton<IRegisterInputDtoValidator, RegisterInputDtoValidator>();
            services.TryAddSingleton<ITickerInputDtoValidator, TickerInputDtoValidator>();
            services.TryAddSingleton<ITransactionInputDtoValidator, TransactionInputDtoValidator>();
            services.TryAddSingleton<IWalletInputDtoValidator, WalletInputDtoValidator>();

            return services;
        }
    }
}