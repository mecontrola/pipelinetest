using MeControla.Core.TestingTools;
using MeControla.Core.TestingTools.FluentAssertions.Extensions;
using MeControla.StockAnalytics.Core.IoC;
using MeControla.StockAnalytics.Core.Validators;

namespace MeControla.StockAnalytics.Core.Tests.IoC
{
    public class ValidatorInjectorTests : BaseInjectorTests
    {
        private const int TOTAL_RECORDS = 6;

        [Fact(DisplayName = "[ValidatorInjector.AddValidators] Deve gerar exceção quando o serviceCollection for nulo.")]
        public void DeveGerarExcecaoQuandoServiceCollectionNulo()
            => RunServiceCollectionNull(serviceCollection => serviceCollection.AddValidators());

        [Fact(DisplayName = "[ValidatorInjector.AddValidators] Verifica se a injeções estão corretas.")]
        public void DeveVerificarInjecao()
        {
            services.AddValidators();

            services.Should().HaveCount(TOTAL_RECORDS);

            services.ShouldAsSingleton<IBrokerInputDtoValidator, BrokerInputDtoValidator>();
            services.ShouldAsSingleton<ICompanyInputDtoValidator, CompanyInputDtoValidator>();
            services.ShouldAsSingleton<IRegisterInputDtoValidator, RegisterInputDtoValidator>();
            services.ShouldAsSingleton<ITickerInputDtoValidator, TickerInputDtoValidator>();
            services.ShouldAsSingleton<ITransactionInputDtoValidator, TransactionInputDtoValidator>();
            services.ShouldAsSingleton<IWalletInputDtoValidator, WalletInputDtoValidator>();
        }
    }
}