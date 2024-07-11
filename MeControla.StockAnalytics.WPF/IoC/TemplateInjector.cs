using MeControla.StockAnalytics.WPF.ViewModels;
using MeControla.StockAnalytics.WPF.Views;
using Microsoft.DotNetCore.WPF.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MeControla.StockAnalytics.WPF.IoC
{
    public static class TemplateInjector
    {
        public static IServiceCollection AddTemplates(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);

            services.AddDataTemplate<BrokerView, BrokerViewModel>();
            services.AddDataTemplate<CompanyView, CompanyViewModel>();
            services.AddDataTemplate<HomeView, HomeViewModel>();
            services.AddDataTemplate<RegisterView, RegisterViewModel>();
            services.AddDataTemplate<SynchronizeView, SynchronizeViewModel>();
            services.AddDataTemplate<TickerView, TickerViewModel>();
            services.AddDataTemplate<TransactionView, TransactionViewModel>();
            services.AddDataTemplate<WalletView, WalletViewModel>();

            return services;
        }
    }
}