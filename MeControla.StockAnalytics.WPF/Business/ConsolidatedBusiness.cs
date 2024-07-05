using MeControla.StockAnalytics.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoreBusiness = MeControla.StockAnalytics.Core.Business.IConsolidatedBusiness;

namespace MeControla.StockAnalytics.WPF.Business
{
    public interface IConsolidatedBusiness
    {
        Task<IList<ConsolidatedDto>> GetAllByWalletIdWithAmountAsync(Guid walletId, CancellationToken cancellationToken);
    }

    public sealed class ConsolidatedBusiness(CoreBusiness business) : IConsolidatedBusiness
    {
        public async Task<IList<ConsolidatedDto>> GetAllByWalletIdWithAmountAsync(Guid walletId, CancellationToken cancellationToken)
            => await business.GetAllByWalletIdWithAmountAsync(walletId, cancellationToken);
    }
}