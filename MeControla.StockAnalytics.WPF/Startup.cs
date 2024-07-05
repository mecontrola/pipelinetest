using MeControla.StockAnalytics.WPF.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Threading;

namespace MeControla.StockAnalytics.WPF
{
    public sealed class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton(new CancellationTokenSource());

            services.AddAppInjectors(Configuration);
        }
    }
}