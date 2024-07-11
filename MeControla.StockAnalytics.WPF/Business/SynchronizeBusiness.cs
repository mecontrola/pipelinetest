using System.Threading;
using System.Threading.Tasks;
using CoreBusiness = MeControla.StockAnalytics.Core.Business.ISynchronizeBusiness;

namespace MeControla.StockAnalytics.WPF.Business
{
    public interface ISynchronizeBusiness
    {
        Task RunAllAsync(CancellationToken cancellationToken);
    }

    public sealed class SynchronizeBusiness(CoreBusiness business) : ISynchronizeBusiness
    {
        public async Task RunAllAsync(CancellationToken cancellationToken)
            => await business.RunAllAsync(cancellationToken);
    }
}