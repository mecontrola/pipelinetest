using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.DataStorage.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IBrokerRetrieveListActiveService
    {
        Task<IList<BrokerLiteDto>> GetListAsync(CancellationToken cancellationToken);
    }

#if DEBUG
    public
#else
    internal
#endif
    sealed class BrokerRetrieveListActiveService(IBrokerRepository brokerRepository,
                                                 IBrokerLiteEntityToDtoMapper brokerLiteEntityToDtoMapper)
        : IBrokerRetrieveListActiveService
    {
        public async Task<IList<BrokerLiteDto>> GetListAsync(CancellationToken cancellationToken)
        {
            var list = await brokerRepository.GetAllActiveAsync(cancellationToken);

            return brokerLiteEntityToDtoMapper.ToMapList(list);
        }
    }
}