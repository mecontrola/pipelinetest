using FluentAssertions;
using MeControla.Core.TestingTools;
using MeControla.Core.TestingTools.FluentAssertions.Extensions;
using MeControla.StockAnalytics.Core.Business;
using MeControla.StockAnalytics.Core.IoC;

namespace MeControla.StockAnalytics.Core.Tests.IoC
{
    public class BusinessInjectorTests : BaseInjectorTests
    {
        private const int TOTAL_RECORDS = 8;

        [Fact(DisplayName = "[BusinessInjector.AddBusiness] Deve gerar exceção quando o serviceCollection for nulo.")]
        public void DeveGerarExcecaoQuandoServiceCollectionNulo()
            => RunServiceCollectionNull(serviceCollection => serviceCollection.AddBusiness());

        [Fact(DisplayName = "[BusinessInjector.AddBusiness] Verifica se a injeções estão corretas.")]
        public void DeveVerificarInjecao()
        {
            services.AddBusiness();

            services.Should().HaveCount(TOTAL_RECORDS);

            services.ShouldAsScoped<IBrokerBusiness, BrokerBusiness>();
            services.ShouldAsScoped<ICompanyBusiness, CompanyBusiness>();
            services.ShouldAsScoped<IConsolidatedBusiness, ConsolidatedBusiness>();
            services.ShouldAsScoped<IRegisterBusiness, RegisterBusiness>();
            services.ShouldAsScoped<ISynchronizeBusiness, SynchronizeBusiness>();
            services.ShouldAsScoped<ITickerBusiness, TickerBusiness>();
            services.ShouldAsScoped<ITransactionBusiness, TransactionBusiness>();
            services.ShouldAsScoped<IWalletBusiness, WalletBusiness>();
        }
    }
}