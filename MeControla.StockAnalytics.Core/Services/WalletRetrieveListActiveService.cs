using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.DataStorage.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IWalletRetrieveListActiveService
    {
        Task<IList<WalletLiteDto>> GetListAsync(CancellationToken cancellationToken);
    }

#if DEBUG
    public
#else
    internal
#endif
    sealed class WalletRetrieveListActiveService(IWalletRepository walletRepository,
                                                 IWalletLiteEntityToDtoMapper walletLiteEntityToDtoMapper)
        : IWalletRetrieveListActiveService
    {
        public async Task<IList<WalletLiteDto>> GetListAsync(CancellationToken cancellationToken)
        {
            var list = await walletRepository.GetAllActiveAsync(cancellationToken);

            return walletLiteEntityToDtoMapper.ToMapList(list);
        }
    }
}