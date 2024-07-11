using FluentAssertions;
using MeControla.StockAnalytics.Core.Builders;
using MeControla.StockAnalytics.Core.Tests.Mocks;
using MeControla.StockAnalytics.Core.Tests.Mocks.Data.Entities;
using MeControla.StockAnalytics.Data.Entities;
using System;

namespace MeControla.StockAnalytics.Core.Tests.Builders
{
    public class BrokerBuilderTests
    {
        [Fact(DisplayName = "[BrokerBuilder.ToBuild] Deve criar a entidade com os dados informados.")]
        public void DeveCriarEntidadeComValoresDefinidos()
        {
            var expected = BrokerMock.CreateFill();
            var actual = BrokerBuilder.GetInstance()
                                      .SetName(DataMock.TEXT_BROKER_NAME)
                                      .ToBuild();

            actual.Should().BeOfType<Broker>();

            actual.Uuid.Should().NotBe(Guid.Empty);
            actual.CreatedAt.Should().NotBe(DateTime.MinValue);

            actual.Should().BeEquivalentTo(expected, opt => opt.Excluding(field => field.Uuid)
                                                               .Excluding(field => field.CreatedAt));
        }
    }
}