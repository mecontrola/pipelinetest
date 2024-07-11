using MeControla.StockAnalytics.Core.Services;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Business
{
    public interface ITickerBusiness
    {
        Task<IList<TickerDto>> RetrieveFilterListAsync(TickerFilterInputDto filterInputDto, CancellationToken cancellationToken);
        Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken);
        Task<TickerDto> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<bool> SaveAsync(Guid? id, TickerInputDto input, CancellationToken cancellationToken);
        Task<IList<TickerLiteDto>> GetAllActiveAsync(CancellationToken cancellationToken);
    }

    public sealed class TickerBusiness(ITickerRetrieveFilterListService tickerRetrieveFilterListService,
                                       ITickerRetrieveService tickerRetrieveService,
                                       ITickerRetrieveListActiveService tickerRetrieveListActiveService,
                                       ITickerSaveService tickerSaveService,
                                       ITickerSwitchAtiveInactiveService tickerSwitchAtiveInactiveService)
        : ITickerBusiness
    {
        public async Task<IList<TickerDto>> RetrieveFilterListAsync(TickerFilterInputDto filterInputDto, CancellationToken cancellationToken)
            => await tickerRetrieveFilterListService.GetFilterListAsync(filterInputDto, cancellationToken);

        public async Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken)
            => await tickerSwitchAtiveInactiveService.SwitchStatusAsync(id, cancellationToken);

        public async Task<TickerDto> GetAsync(Guid id, CancellationToken cancellationToken)
            => await tickerRetrieveService.GetAsync(id, cancellationToken);

        public async Task<bool> SaveAsync(Guid? id, TickerInputDto input, CancellationToken cancellationToken)
            => await tickerSaveService.SaveAsync(id, input, cancellationToken);

        public async Task<IList<TickerLiteDto>> GetAllActiveAsync(CancellationToken cancellationToken)
            => await tickerRetrieveListActiveService.GetListAsync(cancellationToken);
    }
}