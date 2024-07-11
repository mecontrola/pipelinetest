using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IWalletSwitchAtiveInactiveService : IBaseEntitySwitchAtiveInactiveService
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class WalletSwitchAtiveInactiveService(IWalletRepository walletRepository)
        : BaseEntitySwitchAtiveInactiveService<Wallet>(walletRepository), IWalletSwitchAtiveInactiveService
    {
        protected override void ChangeEntity(Wallet entity)
            => entity.Active = !entity.Active;
    }
}