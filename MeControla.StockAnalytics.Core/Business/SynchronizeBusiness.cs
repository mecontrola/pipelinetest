using MeControla.StockAnalytics.Core.Services;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Business
{
    public interface ISynchronizeBusiness
    {
        Task RunAllAsync(CancellationToken cancellationToken);
    }

    public sealed class SynchronizeBusiness(ISynchronizeService synchronizeService)
        : ISynchronizeBusiness
    {
        public async Task RunAllAsync(CancellationToken cancellationToken)
            => await synchronizeService.RunAllAsync(cancellationToken);
    }
}