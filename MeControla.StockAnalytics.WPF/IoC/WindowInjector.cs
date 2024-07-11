using MeControla.StockAnalytics.WPF.ViewModels;
using MeControla.StockAnalytics.WPF.Windows;
using Microsoft.DotNetCore.WPF.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MeControla.StockAnalytics.WPF.IoC
{
    public static class WindowInjector
    {
        public static IServiceCollection AddWindows(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);

            services.AddWindow<MainWindow, MainViewModel>();

            services.AddWindow<SplashWindow, SplashViewModel>();

            services.AddWindow<AboutWindow, AboutViewModel>();
            services.AddWindow<BrokerFormWindow, BrokerFormViewModel>();
            services.AddWindow<CompanyFormWindow, CompanyFormViewModel>();
            services.AddWindow<RegisterFormWindow, RegisterFormViewModel>();
            services.AddWindow<TickerFormWindow, TickerFormViewModel>();
            services.AddWindow<TransactionFormWindow, TransactionFormViewModel>();
            services.AddWindow<WalletFormWindow, WalletFormViewModel>();

            return services;
        }
    }
}