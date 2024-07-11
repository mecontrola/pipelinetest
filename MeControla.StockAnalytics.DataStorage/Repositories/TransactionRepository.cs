using MeControla.Core.Repositories;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.Data.Entities.Filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.DataStorage.Repositories
{
    public interface ITransactionRepository : IFilterAsyncRepository<Transaction, TransactionFilter>, IAsyncRepository<Transaction>
    {
        Task<IList<Transaction>> FindAllByTickerIdAndWalletIdAsync(long tickerId, long walletId, CancellationToken cancellationToken);
    }

    public sealed class TransactionRepository(IDbAppContext context) : BaseAsyncRepository<Transaction>(context, context.Transactions), ITransactionRepository
    {
        public async override Task<Transaction> FindAsync(Guid uuid, CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Include(entity => entity.Broker)
                          .Include(entity => entity.Ticker)
                          .Include(entity => entity.Wallet)
                          .Where(entity => entity.Uuid == uuid)
                          .FirstOrDefaultAsync(cancellationToken);

        public async Task<IList<Transaction>> FindAllByTickerIdAndWalletIdAsync(long tickerId, long walletId, CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => entity.TickerId == tickerId
                                        && entity.WalletId == walletId)
                          .OrderBy(entity => entity.Date)
                          .ToListAsync(cancellationToken);

        public async Task<IList<Transaction>> FindFilterAllAsync(TransactionFilter filter, CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Include(entity => entity.Broker)
                          .Include(entity => entity.Ticker)
                          .Include(entity => entity.Wallet)
                          .Where(entity => (!filter.BrokerId.HasValue || filter.BrokerId.Value == Guid.Empty || (filter.BrokerId.HasValue && entity.Broker.Uuid == filter.BrokerId))
                                        && (!filter.TickerId.HasValue || filter.TickerId.Value == Guid.Empty || (filter.TickerId.HasValue && entity.Ticker.Uuid == filter.TickerId))
                                        && (!filter.WalletId.HasValue || filter.WalletId.Value == Guid.Empty || (filter.WalletId.HasValue && entity.Wallet.Uuid == filter.WalletId))
                                        && (!filter.Action.HasValue || (filter.Action.HasValue && entity.Action == filter.Action.Value)))
                          .ToListAsync(cancellationToken);
    }
}