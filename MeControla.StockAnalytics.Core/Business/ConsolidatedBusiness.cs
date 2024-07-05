using MeControla.StockAnalytics.Core.Services;
using MeControla.StockAnalytics.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Business
{
    public interface IConsolidatedBusiness
    {
        Task<IList<ConsolidatedDto>> GetAllByWalletIdWithAmountAsync(Guid walletId, CancellationToken cancellationToken);
    }

    public sealed class ConsolidatedBusiness(IConsolidatedRetrieveListByWalletIdWithAmountService consolidatedRetrieveListByWalletIdWithAmountService)
        : IConsolidatedBusiness
    {
        public async Task<IList<ConsolidatedDto>> GetAllByWalletIdWithAmountAsync(Guid walletId, CancellationToken cancellationToken)
            => await consolidatedRetrieveListByWalletIdWithAmountService.GetListAsync(walletId, cancellationToken);
    }
}