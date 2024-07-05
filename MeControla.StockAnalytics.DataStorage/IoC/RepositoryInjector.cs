using MeControla.StockAnalytics.DataStorage.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Diagnostics;

namespace MeControla.StockAnalytics.DataStorage.IoC
{
    public static class RepositoryInjector
    {
        private const string DATABASE_CONNECTION_NAME = "DefaultConnection";

        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(services);

            var connectionString = configuration.GetConnectionString(DATABASE_CONNECTION_NAME);

            services.AddDbContext<IDbAppContext, DbAppContext>(builder => ConfigureDbAppContext(builder, connectionString), ServiceLifetime.Scoped);

            services.TryAddTransient<IBrokerRepository, BrokerRepository>();
            services.TryAddTransient<ICompanyRepository, CompanyRepository>();
            services.TryAddTransient<IConsolidatedRepository, ConsolidatedRepository>();
            services.TryAddTransient<IRegisterRepository, RegisterRepository>();
            services.TryAddTransient<ITickerRepository, TickerRepository>();
            services.TryAddTransient<ITransactionRepository, TransactionRepository>();
            services.TryAddTransient<IWalletRepository, WalletRepository>();

            return services;
        }

        private static void ConfigureDbAppContext(DbContextOptionsBuilder builder, string connectionString)
            => builder.UseSqlite(connectionString)
                      .LogTo(s => Debug.WriteLine(s));
    }
}