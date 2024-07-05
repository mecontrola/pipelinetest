using MeControla.StockAnalytics.Core.Builders;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Core.Validators;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IWalletSaveService : IBaseEntitySaveService<WalletInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class WalletSaveService(IWalletRepository walletRepository,
                                   IWalletInputDtoValidator walletInputDtoValidator)
        : BaseEntitySaveService<Wallet, WalletInputDto>(walletRepository, walletInputDtoValidator), IWalletSaveService
    {
        protected override void FillEntity(Wallet entity, WalletInputDto input)
        {
            entity.Name = input.Name;

            if (entity.Id == 0)
                entity.Active = true;
        }

        protected override Wallet BuildEntity()
            => WalletBuilder.GetInstance().ToBuild();
    }
}