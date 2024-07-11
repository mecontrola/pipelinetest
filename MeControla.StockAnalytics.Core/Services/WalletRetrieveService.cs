using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IWalletRetrieveService : IBaseEntityRetrieveService<WalletDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class WalletRetrieveService(IWalletRepository walletRepository,
                                       IWalletEntityToDtoMapper walletEntityToDtoMapper)
        : BaseEntityRetrieveService<Wallet, WalletDto>(walletRepository, walletEntityToDtoMapper), IWalletRetrieveService
    { }
}