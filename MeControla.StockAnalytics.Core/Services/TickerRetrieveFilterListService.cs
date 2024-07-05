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
    public interface ITickerRetrieveFilterListService : IBaseEntityRetrieveFilterListService<TickerDto, TickerFilterInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TickerRetrieveFilterListService(ITickerRepository tickerRepository,
                                                 ITickerInputDtoToFilterEntityMapper tickerInputDtoToFilterEntityMapper,
                                                 ITickerEntityToDtoMapper tickerEntityToDtoMapper)
        : BaseEntityRetrieveFilterListService<Ticker, TickerDto, TickerFilter, TickerFilterInputDto>(tickerRepository,
                                                                                                     tickerInputDtoToFilterEntityMapper,
                                                                                                     tickerEntityToDtoMapper)
        , ITickerRetrieveFilterListService
    { }
}