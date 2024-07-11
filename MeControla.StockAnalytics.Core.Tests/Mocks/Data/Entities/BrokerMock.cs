using MeControla.StockAnalytics.Data.Entities;

namespace MeControla.StockAnalytics.Core.Tests.Mocks.Data.Entities
{
    public class BrokerMock
    {
        public static Broker Create()
            => new();

        public static Broker CreateFill()
            => new()
            {
                Name = DataMock.TEXT_BROKER_NAME,
                Active = DataMock.BOOL_TRUE
            };
    }
}
