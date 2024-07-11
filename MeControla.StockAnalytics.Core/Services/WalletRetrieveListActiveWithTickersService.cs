using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.DataStorage.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IWalletRetrieveListActiveWithTickersService
    {
        Task<IList<WalletLiteDto>> GetListAsync(CancellationToken cancellationToken);
    }

#if DEBUG
    public
#else
    internal
#endif
    sealed class WalletRetrieveListActiveWithTickersService(IWalletRepository walletRepository,
                                                            IWalletLiteEntityToDtoMapper walletLiteEntityToDtoMapper)
        : IWalletRetrieveListActiveWithTickersService
    {
        public async Task<IList<WalletLiteDto>> GetListAsync(CancellationToken cancellationToken)
        {
            var list = await walletRepository.FindAllActiveWithTickersAsync(cancellationToken);

            return walletLiteEntityToDtoMapper.ToMapList(list);
        }
    }
}