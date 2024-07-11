using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.DataStorage.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ITickerRetrieveListActiveService
    {
        Task<IList<TickerLiteDto>> GetListAsync(CancellationToken cancellationToken);
    }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TickerRetrieveListActiveService(ITickerRepository tickerRepository,
                                                 ITickerLiteEntityToDtoMapper tickerLiteEntityToDtoMapper)
        : ITickerRetrieveListActiveService
    {
        public async Task<IList<TickerLiteDto>> GetListAsync(CancellationToken cancellationToken)
        {
            var list = await tickerRepository.GetAllActiveAsync(cancellationToken);

            return tickerLiteEntityToDtoMapper.ToMapList(list);
        }
    }
}
