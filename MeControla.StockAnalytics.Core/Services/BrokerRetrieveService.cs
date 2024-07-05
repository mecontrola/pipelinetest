using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IBrokerRetrieveService : IBaseEntityRetrieveService<BrokerDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class BrokerRetrieveService(IBrokerRepository brokerRepository,
                                       IBrokerEntityToDtoMapper brokerEntityToDtoMapper)
        : BaseEntityRetrieveService<Broker, BrokerDto>(brokerRepository, brokerEntityToDtoMapper), IBrokerRetrieveService
    { }
}