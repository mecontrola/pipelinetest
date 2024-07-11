using MeControla.Core.Exceptions;
using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.DataStorage.Repositories;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IConsolidatedRetrieveListByWalletIdWithAmountService
    {
        Task<IList<ConsolidatedDto>> GetListAsync(Guid walletUuid, CancellationToken cancellationToken);
    }

#if DEBUG
    public
#else
    internal
#endif
    sealed class ConsolidatedRetrieveListByWalletIdWithAmountService(IConsolidatedRepository consolidatedRepository,
                                                                     IWalletRepository walletRepository,
                                                                     IConsolidatedEntityToDtoMapper companyLiteEntityToDtoMapper)
        : IConsolidatedRetrieveListByWalletIdWithAmountService
    {
        public async Task<IList<ConsolidatedDto>> GetListAsync(Guid walletUuid, CancellationToken cancellationToken)
        {
            var wallet = await walletRepository.FindAsync(walletUuid, cancellationToken)
                      ?? throw new NotFoundException();

            var list = await consolidatedRepository.FindByWalletIdWithAmountAsync(wallet.Id, cancellationToken);

            return companyLiteEntityToDtoMapper.ToMapList(list);
        }
    }
}