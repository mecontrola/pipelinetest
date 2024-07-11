using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ITickerRetrieveService : IBaseEntityRetrieveService<TickerDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TickerRetrieveService(ITickerRepository tickerRepository,
                                       ITickerEntityToDtoMapper tickerEntityToDtoMapper)
        : BaseEntityRetrieveService<Ticker, TickerDto>(tickerRepository, tickerEntityToDtoMapper), ITickerRetrieveService
    { }
}