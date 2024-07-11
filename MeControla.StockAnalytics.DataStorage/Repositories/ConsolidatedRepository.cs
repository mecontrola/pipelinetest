using MeControla.Core.Repositories;
using MeControla.StockAnalytics.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.DataStorage.Repositories
{
    public interface IConsolidatedRepository : IAsyncRepository<Consolidated>
    {
        Task<Consolidated> FindByTickerIdAndWalletIdAsync(long tickerId, long walletId, CancellationToken cancellationToken);
        Task<IList<Consolidated>> FindByWalletIdWithAmountAsync(long walletId, CancellationToken cancellationToken);
    }

    public sealed class ConsolidatedRepository(IDbAppContext context) : BaseAsyncRepository<Consolidated>(context, context.Consolidated), IConsolidatedRepository
    {
        public async Task<Consolidated> FindByTickerIdAndWalletIdAsync(long tickerId, long walletId, CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => entity.TickerId == tickerId
                                        && entity.WalletId == walletId)
                          .FirstOrDefaultAsync(cancellationToken);

        public async Task<IList<Consolidated>> FindByWalletIdWithAmountAsync(long walletId, CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Include(entity => entity.Ticker)
                          .Include(entity => entity.Wallet)
                          .Where(entity => entity.WalletId == walletId
                                        && entity.Amount > 0)
                          .ToListAsync(cancellationToken);
    }
}