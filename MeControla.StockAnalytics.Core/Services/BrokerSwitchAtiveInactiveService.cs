using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IBrokerSwitchAtiveInactiveService : IBaseEntitySwitchAtiveInactiveService
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class BrokerSwitchAtiveInactiveService(IBrokerRepository brokerRepository)
        : BaseEntitySwitchAtiveInactiveService<Broker>(brokerRepository), IBrokerSwitchAtiveInactiveService
    {
        protected override void ChangeEntity(Broker entity)
            => entity.Active = !entity.Active;
    }
}