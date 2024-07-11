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
    public interface ITickerRepository : IFilterAsyncRepository<Ticker, TickerFilter>, IAsyncRepository<Ticker>
    {
        Task<Ticker> GetByNameAsync(string name, CancellationToken cancellationToken);
        Task<IList<Ticker>> GetAllActiveAsync(CancellationToken cancellationToken);
    }

    public sealed class TickerRepository(IDbAppContext context) : BaseAsyncRepository<Ticker>(context, context.Tickers), ITickerRepository
    {
        public async Task<Ticker> GetByNameAsync(string name, CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => entity.Name == name)
                          .FirstOrDefaultAsync(cancellationToken);

        public async Task<IList<Ticker>> GetAllActiveAsync(CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => entity.Active)
                          .OrderBy(entity => entity.Name)
                          .ToListAsync(cancellationToken);

        public async Task<IList<Ticker>> FindFilterAllAsync(TickerFilter filter, CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => (string.IsNullOrWhiteSpace(filter.Name) || (!string.IsNullOrWhiteSpace(filter.Name) && entity.Name.ToLower().Contains(filter.Name.ToLower())))
                                        && (!filter.Active.HasValue || (filter.Active.HasValue && entity.Active == filter.Active.Value)))
                          .ToListAsync(cancellationToken);
    }
}