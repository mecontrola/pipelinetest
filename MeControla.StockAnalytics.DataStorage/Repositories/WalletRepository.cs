using MeControla.Core.Repositories;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.Data.Entities.Filters;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.DataStorage.Repositories
{
    public interface IWalletRepository : IFilterAsyncRepository<Wallet, WalletFilter>, IAsyncRepository<Wallet>
    {
        Task<IList<Wallet>> GetAllActiveAsync(CancellationToken cancellationToken);
        Task<IList<Wallet>> FindAllActiveWithTickersAsync(CancellationToken cancellationToken);
    }

    public sealed class WalletRepository(IDbAppContext context) : BaseAsyncRepository<Wallet>(context, context.Wallets), IWalletRepository
    {
        public async Task<IList<Wallet>> GetAllActiveAsync(CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => entity.Active)
                          .ToListAsync(cancellationToken);

        public async Task<IList<Wallet>> FindAllActiveWithTickersAsync(CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => entity.Active
                                        && entity.Tickers.Any(join => join.Amount > 0))
                          .ToListAsync(cancellationToken);

        public async Task<IList<Wallet>> FindFilterAllAsync(WalletFilter filter, CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => (string.IsNullOrWhiteSpace(filter.Name) || (!string.IsNullOrWhiteSpace(filter.Name) && entity.Name.ToLower().Contains(filter.Name.ToLower())))
                                        && (!filter.Active.HasValue || (filter.Active.HasValue && entity.Active == filter.Active.Value)))
                          .ToListAsync(cancellationToken);
    }
}