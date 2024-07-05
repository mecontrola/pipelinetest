using MeControla.Core.Integrations.B3;
using MeControla.Core.TestingTools;
using MeControla.StockAnalytics.Core.IoC;
using MeControla.StockAnalytics.DataStorage.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;

namespace MeControla.StockAnalytics.Core.Tests.IoC
{
    public class CoreInjectorTests : BaseInjectorTests
    {
        private readonly IConfiguration configuration;

        public CoreInjectorTests()
            => configuration = Substitute.For<IConfiguration>();

        [Fact(DisplayName = "[CoreInjector.AddCoreInjectors] Deve gerar exceção quando o serviceCollection for nulo.")]
        public void DeveGerarExcecaoQuandoServiceCollectionNulo()
            => RunServiceCollectionNull(serviceCollection => serviceCollection.AddCoreInjectors(configuration));


        [Fact(DisplayName = "[MappersInjector.AddMappers] Verifica se a injeções estão corretas.")]
        public void DeveVerificarInjecao()
        {
            var services = Substitute.For<IServiceCollection>();

            services.AddCoreInjectors(configuration);

            services.Received().AddRepositories(configuration);
            services.Received().AddBusiness();
            services.Received().AddMappers();
            services.Received().AddServices();
            services.Received().AddValidators();
            services.Received().AddB3Integration();
        }
    }
}