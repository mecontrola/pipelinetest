using Autofac.Extensions.DependencyInjection;
using MeControla.StockAnalytics.WPF.Windows;
using Microsoft.DotNetCore.Hosting;
using Microsoft.DotNetCore.Hosting.WPF;
using Microsoft.DotNetCore.WPF.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System.Reflection;
using System.Threading;
using System.Windows;

namespace MeControla.StockAnalytics.WPF
{
    sealed partial class App : Application
    {
        private const string APP_INSTANCE_NAME = "StockAnalytics-AB963735-1780-4AE1-A2D9-44D73D988BA8";

        private readonly IAppSingletonInstance appInstance;
        private readonly IHost host;
        private readonly ITimerBackground background;

        public App()
        {
            this.InitializeCultures();

            appInstance = new AppSingletonInstance(APP_INSTANCE_NAME);

            host = CreateHostBuilder().Build();
            background = host.Services.GetService<ITimerBackground>();
        }

        private static IHostBuilder CreateHostBuilder()
            => Host.CreateDefaultBuilder()
                   .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                   .ConfigureServices((hostContext, services) =>
                   {
                       var startup = new Startup(hostContext.Configuration);
                       startup.ConfigureServices(services);
                   })
                   .ConfigureAppConfiguration((hostContext, config) =>
                   {
                       var env = hostContext.HostingEnvironment;

                       config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                             .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

                       if (env.IsDevelopment())
                       {
                           if (!string.IsNullOrWhiteSpace(env.ApplicationName))
                           {
                               var appAssembly = Assembly.Load(new AssemblyName(env.ApplicationName));
                               if (appAssembly != null)
                                   config.AddUserSecrets(appAssembly, optional: true);
                           }
                       }

                       config.AddEnvironmentVariables();
                   })
                   .ConfigureLogging((hostingContext, loggingBuilder) =>
                   {
                       loggingBuilder.Configure(opt =>
                       {
                           opt.ActivityTrackingOptions = ActivityTrackingOptions.SpanId
                                                       | ActivityTrackingOptions.TraceId
                                                       | ActivityTrackingOptions.ParentId;
                       });
                       loggingBuilder.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                       loggingBuilder.AddConsole();
                       loggingBuilder.AddDebug();
                       loggingBuilder.AddEventSourceLogger();
                   })
                   .UseSerilog((context, loggerConfig) => loggerConfig.ReadFrom.Configuration(context.Configuration), writeToProviders: true);


        protected override async void OnStartup(StartupEventArgs e)
        {
            if (!appInstance.HasInstance())
            {
                Current.Shutdown();

                return;
            }

            await host.StartAsync();

            var language = host.Services.GetService<ILanguage>();
            language?.Initialize();

            var splashWindow = host.Services.GetService<SplashWindow>();
            splashWindow?.Show();

            await background?.ExecuteAsync(CancellationToken.None);

            var mainWindow = host.Services.GetService<MainWindow>();
            mainWindow?.Show();

            splashWindow?.Close();

            base.OnStartup(e);

        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await host.StopAsync();

            host.Dispose();
            background?.Dispose();
            appInstance.Dispose();

            base.OnExit(e);
        }
    }
}