using FluentAssertions;
using MeControla.Core.TestingTools;
using MeControla.Core.TestingTools.FluentAssertions.Extensions;
using MeControla.StockAnalytics.Core.IoC;
using MeControla.StockAnalytics.Core.Services;

namespace MeControla.StockAnalytics.Core.Tests.IoC
{
    public class ServicesInjectorTests : BaseInjectorTests
    {
        private const int TOTAL_RECORDS = 31;

        [Fact(DisplayName = "[ServicesInjector.AddServices] Deve gerar exceção quando o serviceCollection for nulo.")]
        public void DeveGerarExcecaoQuandoServiceCollectionNulo()
            => RunServiceCollectionNull(serviceCollection => serviceCollection.AddServices());

        [Fact(DisplayName = "[ServicesInjector.AddServices] Verifica se a injeções estão corretas.")]
        public void DeveVerificarInjecao()
        {
            services.AddServices();
            services.Should().HaveCount(TOTAL_RECORDS);

            services.ShouldAsScoped<IBrokerRetrieveFilterListService, BrokerRetrieveFilterListService>();
            services.ShouldAsScoped<IBrokerRetrieveListActiveService, BrokerRetrieveListActiveService>();
            services.ShouldAsScoped<IBrokerRetrieveService, BrokerRetrieveService>();
            services.ShouldAsScoped<IBrokerSaveService, BrokerSaveService>();
            services.ShouldAsScoped<IBrokerSwitchAtiveInactiveService, BrokerSwitchAtiveInactiveService>();

            services.ShouldAsScoped<ICompanyRetrieveFilterListService, CompanyRetrieveFilterListService>();
            services.ShouldAsScoped<ICompanyRetrieveListActiveService, CompanyRetrieveListActiveService>();
            services.ShouldAsScoped<ICompanyRetrieveService, CompanyRetrieveService>();
            services.ShouldAsScoped<ICompanySaveService, CompanySaveService>();
            services.ShouldAsScoped<ICompanySwitchAtiveInactiveService, CompanySwitchAtiveInactiveService>();

            services.ShouldAsScoped<IConsolidateAllTransactionsService, ConsolidateAllTransactionsService>();
            services.ShouldAsScoped<IConsolidatedRetrieveListByWalletIdWithAmountService, ConsolidatedRetrieveListByWalletIdWithAmountService>();

            services.ShouldAsScoped<IRegisterRetrieveFilterListService, RegisterRetrieveFilterListService>();
            services.ShouldAsScoped<IRegisterRetrieveService, RegisterRetrieveService>();
            services.ShouldAsScoped<IRegisterSaveService, RegisterSaveService>();
            services.ShouldAsScoped<IRegisterSwitchAtiveInactiveService, RegisterSwitchAtiveInactiveService>();
            services.ShouldAsScoped<ISynchronizeService, SynchronizeService>();

            services.ShouldAsScoped<ITickerRetrieveFilterListService, TickerRetrieveFilterListService>();
            services.ShouldAsScoped<ITickerRetrieveListActiveService, TickerRetrieveListActiveService>();
            services.ShouldAsScoped<IWalletRetrieveListActiveWithTickersService, WalletRetrieveListActiveWithTickersService>();
            services.ShouldAsScoped<ITickerRetrieveService, TickerRetrieveService>();
            services.ShouldAsScoped<ITickerSaveService, TickerSaveService>();
            services.ShouldAsScoped<ITickerSwitchAtiveInactiveService, TickerSwitchAtiveInactiveService>();

            services.ShouldAsScoped<ITransactionRetrieveFilterListService, TransactionRetrieveFilterListService>();
            services.ShouldAsScoped<ITransactionRetrieveService, TransactionRetrieveService>();
            services.ShouldAsScoped<ITransactionSaveService, TransactionSaveService>();

            services.ShouldAsScoped<IWalletRetrieveFilterListService, WalletRetrieveFilterListService>();
            services.ShouldAsScoped<IWalletRetrieveListActiveService, WalletRetrieveListActiveService>();
            services.ShouldAsScoped<IWalletRetrieveService, WalletRetrieveService>();
            services.ShouldAsScoped<IWalletSaveService, WalletSaveService>();
            services.ShouldAsScoped<IWalletSwitchAtiveInactiveService, WalletSwitchAtiveInactiveService>();
        }
    }
}