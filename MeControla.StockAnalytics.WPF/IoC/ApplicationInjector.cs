using MeControla.StockAnalytics.Core.IoC;
using MeControla.StockAnalytics.WPF.Datas.Enums;
using MeControla.StockAnalytics.WPF.Tools;
using Microsoft.DotNetCore.Hosting;
using Microsoft.DotNetCore.Hosting.WPF;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Windows;

namespace MeControla.StockAnalytics.WPF.IoC
{
    public static class ApplicationInjector
    {
        public static IServiceCollection AddAppInjectors(this IServiceCollection services, IConfiguration configuration)
            => services.AddCoreInjectors(configuration)
                       .AddBusiness()
                       .AddWindows()
                       .AddTemplates()
                       .AddTools();

        private static IServiceCollection AddTools(this IServiceCollection services)
        {
            services.TryAddSingleton<ICommandManager, CommandManager>();
            services.TryAddSingleton<IUIManager, UIManager>();
            services.TryAddSingleton<ITimerBackground>(sp =>
            {
                return new TimerBackground();
            });

            services.AddLanguage<Languages>(opt =>
            {
                opt.DefaultValue = Languages.enUS;
                opt.Prefix = "Language";
                opt.ResourcesPath = @".\Resources\Languages";
                opt.UpdateResource = uri =>
                {
                    var dictionary = new ResourceDictionary() { Source = uri };
                    Application.Current.Resources.MergedDictionaries.Add(dictionary);
                };
            });

            return services;
        }
    }
}