using MeControla.Core.WPF.Business;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoreBusiness = MeControla.StockAnalytics.Core.Business.ITickerBusiness;

namespace MeControla.StockAnalytics.WPF.Business
{
    public interface ITickerBusiness : IBaseFormViewModelBusiness<TickerDto, TickerInputDto>, IBaseListViewModelBusiness<TickerDto, TickerFilterInputDto>
    {
        Task<IList<TickerLiteDto>> GetAllActiveAsync(CancellationToken cancellationToken);
    }

    public sealed class TickerBusiness(CoreBusiness business) : ITickerBusiness
    {
        public async Task<IList<TickerDto>> GetFilterAllAsync(TickerFilterInputDto filter, CancellationToken cancellationToken)
            => await business.RetrieveFilterListAsync(filter, cancellationToken);

        public async Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken)
            => await business.SwitchAtiveInactiveAsync(id, cancellationToken);

        public async Task<TickerDto> GetAsync(Guid id, CancellationToken cancellationToken)
            => await business.GetAsync(id, cancellationToken);

        public async Task<bool> SaveAsync(Guid? id, TickerInputDto input, CancellationToken cancellationToken)
            => await business.SaveAsync(id, input, cancellationToken);

        public async Task<IList<TickerLiteDto>> GetAllActiveAsync(CancellationToken cancellationToken)
            => await business.GetAllActiveAsync(cancellationToken);
    }
}