using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ITickerSwitchAtiveInactiveService : IBaseEntitySwitchAtiveInactiveService
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TickerSwitchAtiveInactiveService(ITickerRepository tickerRepository)
        : BaseEntitySwitchAtiveInactiveService<Ticker>(tickerRepository), ITickerSwitchAtiveInactiveService
    {
        protected override void ChangeEntity(Ticker entity)
            => entity.Active = !entity.Active;
    }
}