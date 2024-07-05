using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Core.Mappers.InputDtoToFilterEntity;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.Data.Entities.Filters;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IBrokerRetrieveFilterListService : IBaseEntityRetrieveFilterListService<BrokerDto, BrokerFilterInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class BrokerRetrieveFilterListService(IBrokerRepository brokerRepository,
                                                 IBrokerInputDtoToFilterEntityMapper brokerInputDtoToFilterEntityMapper,
                                                 IBrokerEntityToDtoMapper brokerEntityToDtoMapper)
        : BaseEntityRetrieveFilterListService<Broker, BrokerDto, BrokerFilter, BrokerFilterInputDto>(brokerRepository,
                                                                                                     brokerInputDtoToFilterEntityMapper,
                                                                                                     brokerEntityToDtoMapper)
        , IBrokerRetrieveFilterListService
    { }
}