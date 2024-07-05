using FluentAssertions;
using MeControla.Core.TestingTools;
using MeControla.Core.TestingTools.FluentAssertions.Extensions;
using MeControla.StockAnalytics.Core.IoC;
using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Core.Mappers.InputDtoToFilterEntity;

namespace MeControla.StockAnalytics.Core.Tests.IoC
{
    public class MappersInjectorTests : BaseInjectorTests
    {
        private const int TOTAL_RECORDS = 17;

        [Fact(DisplayName = "[MappersInjector.AddMappers] Deve gerar exceção quando o serviceCollection for nulo.")]
        public void DeveGerarExcecaoQuandoServiceCollectionNulo()
            => RunServiceCollectionNull(serviceCollection => serviceCollection.AddMappers());

        [Fact(DisplayName = "[MappersInjector.AddMappers] Verifica se a injeções estão corretas.")]
        public void DeveVerificarInjecao()
        {
            services.AddMappers();

            services.Should().HaveCount(TOTAL_RECORDS);

            services.ShouldAsSingleton<IBrokerEntityToDtoMapper, BrokerEntityToDtoMapper>();
            services.ShouldAsSingleton<IBrokerLiteEntityToDtoMapper, BrokerLiteEntityToDtoMapper>();
            services.ShouldAsSingleton<ICompanyEntityToDtoMapper, CompanyEntityToDtoMapper>();
            services.ShouldAsSingleton<ICompanyLiteEntityToDtoMapper, CompanyLiteEntityToDtoMapper>();
            services.ShouldAsSingleton<IConsolidatedEntityToDtoMapper, ConsolidatedEntityToDtoMapper>();
            services.ShouldAsSingleton<IRegisterEntityToDtoMapper, RegisterEntityToDtoMapper>();
            services.ShouldAsSingleton<ITickerEntityToDtoMapper, TickerEntityToDtoMapper>();
            services.ShouldAsSingleton<ITickerLiteEntityToDtoMapper, TickerLiteEntityToDtoMapper>();
            services.ShouldAsSingleton<ITransactionEntityToDtoMapper, TransactionEntityToDtoMapper>();
            services.ShouldAsSingleton<IWalletEntityToDtoMapper, WalletEntityToDtoMapper>();
            services.ShouldAsSingleton<IWalletLiteEntityToDtoMapper, WalletLiteEntityToDtoMapper>();

            services.ShouldAsSingleton<IBrokerInputDtoToFilterEntityMapper, BrokerInputDtoToFilterEntityMapper>();
            services.ShouldAsSingleton<ICompanyInputDtoToFilterEntityMapper, CompanyInputDtoToFilterEntityMapper>();
            services.ShouldAsSingleton<IRegisterInputDtoToFilterEntityMapper, RegisterInputDtoToFilterEntityMapper>();
            services.ShouldAsSingleton<ITickerInputDtoToFilterEntityMapper, TickerInputDtoToFilterEntityMapper>();
            services.ShouldAsSingleton<ITransactionInputDtoToFilterEntityMapper, TransactionInputDtoToFilterEntityMapper>();
            services.ShouldAsSingleton<IWalletInputDtoToFilterEntityMapper, WalletInputDtoToFilterEntityMapper>();
        }
    }
}