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
    public interface IBrokerRepository : IFilterAsyncRepository<Broker, BrokerFilter>, IAsyncRepository<Broker>
    {
        Task<IList<Broker>> GetAllActiveAsync(CancellationToken cancellationToken);
    }

    public sealed class BrokerRepository(IDbAppContext context) : BaseAsyncRepository<Broker>(context, context.Brokers), IBrokerRepository
    {
        public async Task<IList<Broker>> GetAllActiveAsync(CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => entity.Active)
                          .ToListAsync(cancellationToken);

        public async Task<IList<Broker>> FindFilterAllAsync(BrokerFilter filter, CancellationToken cancellationToken)
            => await dbSet.AsNoTracking()
                          .Where(entity => (string.IsNullOrWhiteSpace(filter.Name) || (!string.IsNullOrWhiteSpace(filter.Name) && entity.Name.ToLower().Contains(filter.Name.ToLower())))
                                        && (!filter.Active.HasValue || (filter.Active.HasValue && entity.Active == filter.Active.Value)))
                          .ToListAsync(cancellationToken);
    }
}